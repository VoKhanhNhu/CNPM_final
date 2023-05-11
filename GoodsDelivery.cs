using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DataTable = System.Data.DataTable;
using LicenseContext = OfficeOpenXml.LicenseContext;
using ExcelDataReader;
using ExcelDataReader.Exceptions;

namespace VKN
{
    public partial class GoodsDelivery : Form
    {
        public GoodsDelivery()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        DataTable ShowInformation(string OrderID)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Goods ID");
            dt.Columns.Add("Goods Name");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Goods Cost");
            dt.Columns.Add("Total Cost");

            var fileInfo = new FileInfo(@"D:\NT106\VKN\order.xlsx");
            using (var package1 = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package1.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                // Duyệt qua từng dòng để lấy thông tin hàng hóa trong đơn hàng
                for (int row = 2; row <= rowCount; row++)
                {
                    if (OrderID == worksheet.Cells[row, 1].Value?.ToString())
                    {
                        string excelGoodsID = worksheet.Cells[row, 3].Value?.ToString();
                        string excelGoodsName = worksheet.Cells[row, 4].Value?.ToString();
                        string excelQuantity = worksheet.Cells[row, 5].Value?.ToString();
                        string excelGoodsCost = worksheet.Cells[row, 6].Value?.ToString();
                        string excelTotalCost = worksheet.Cells[row, 7].Value?.ToString();

                        dt.Rows.Add(excelGoodsID, excelGoodsName, excelQuantity, excelGoodsCost, excelTotalCost);
                    }
                }
                return dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = deliveryTB.Text;
            string order = orderTB.Text;

            if (string.IsNullOrEmpty(order))
            {
                MessageBox.Show("Please enter OrderID.");
                return;
            }

            // Đọc dữ liệu từ file Excel
            var fileInfo = new FileInfo(@"D:\NT106\VKN\delivery.xlsx");
            using (var package = new ExcelPackage(fileInfo))
            {
                ExcelWorkbook wb = package.Workbook;
                ExcelWorksheet worksheet = wb.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                // Duyệt qua từng dòng để kiểm tra orderID và deliveryID
                for (int row = 2; row <= rowCount; row++)
                {
                    string excelOrderID = worksheet.Cells[row, 1].Value?.ToString();
                    string excelDeliveryID = worksheet.Cells[row, 2].Value?.ToString();

                    if (order == excelOrderID && id == excelDeliveryID && excelDeliveryID != "")
                    {
                        DateTime excelDeliveryDate = (DateTime)worksheet.Cells[row, 3].Value;

                        string excelOrderStatus = worksheet.Cells[row, 4].Value?.ToString();
                        string excelTotalCost = worksheet.Cells[row, 5].Value?.ToString();
                        string excelPaymentStatus = worksheet.Cells[row, 6].Value?.ToString();

                        dateDTP.Value = excelDeliveryDate;
                        deliveryStatusTB.Text = excelOrderStatus;
                        totalCostTB.Text = excelTotalCost;
                        paymentStatusTB.Text = excelPaymentStatus;

                        dataGridView1.DataSource = ShowInformation(excelOrderID);
                        return;
                    }
                    else if (order == excelOrderID && id == "")
                    {
                        if (worksheet.Cells[row, 2].Value != null) deliveryTB.Text = worksheet.Cells[row, 2].Value.ToString();
                        else if (row <= 2)
                        {
                            worksheet.Cells[row, 2].Value = "D001";
                            deliveryTB.Text = "D001";
                        }
                        else
                        {
                            string ws = worksheet.Cells[row - 1, 2].Value.ToString();
                            string s = "";
                            for (int i = 1; i < ws.Length; i++)
                                s += ws[i];
                            int d = int.Parse(s) + 1;
                            s = "D";
                            s += d.ToString().PadLeft(3,'0');
                            worksheet.Cells[row, 2].Value = s;
                            deliveryTB.Text = s;
                        } 
                            
                        DateTime excelDeliveryDate = (DateTime)worksheet.Cells[row, 3].Value;

                        deliveryStatusTB.Text = worksheet.Cells[row, 4].Value?.ToString();
                        totalCostTB.Text = worksheet.Cells[row, 5].Value?.ToString();
                        paymentStatusTB.Text = worksheet.Cells[row, 6].Value?.ToString();

                        dateDTP.Value = excelDeliveryDate;


                        DataTable dt = new DataTable();
                        dt.Columns.Add("Goods ID");
                        dt.Columns.Add("Goods Name");
                        dt.Columns.Add("Quantity");
                        dt.Columns.Add("Goods Cost");
                        dt.Columns.Add("Total Cost");

                        dataGridView1.DataSource = ShowInformation(excelOrderID);
                        return;
                    }
                    else if (order == excelOrderID && id != excelDeliveryID)
                    {
                        // Nếu không tìm thấy DeliveryID hiển thị thông báo lỗi
                        MessageBox.Show("Wrong DeliveryID. Please try again!");
                        return;
                    }                        
                }

                // Nếu không tìm thấy OrderID hiển thị thông báo lỗi
                MessageBox.Show("Invalid OrderID. Please try again.");
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            var fileInfo = new FileInfo(@"D:\NT106\VKN\delivery.xlsx");
            using (var package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                // Duyệt qua từng dòng để kiểm tra orderID và deliveryID
                for (int row = 2; row <= rowCount; row++)
                {
                    string excelOrderID = worksheet.Cells[row, 1].Value?.ToString();
                    string excelDeliveryID = worksheet.Cells[row, 2].Value?.ToString();

                    if (orderTB.Text == excelOrderID)
                    {
                        DateTime dt = dateDTP.Value;
                        object[] data = new object[7];

                        data[1] = deliveryTB.Text;
                        data[2] = dt;
                        data[3] = deliveryStatusTB.Text;
                        data[4] = totalCostTB.Text;
                        data[5] = paymentStatusTB.Text;


                        worksheet.Cells[row, 1].LoadFromArrays(new object[][] { data });
                        worksheet.Cells[row, 1].Value = orderTB.Text;

                        package.Save();
                        MessageBox.Show("Goods Delivery saved successfully!");
                        return;
                    }
                }
            }
        }
        
         private void printB_Click(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += new PrintPageEventHandler(this.printDocument_PrintPage);
            PrintDialog dialog = new PrintDialog();
            dialog.Document = document;
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK) document.Print();            
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string s = "Order ID: " + orderTB.Text + "\n";
            e.Graphics.DrawString(s, new Font("Arial", 12), Brushes.Black, 100, 100);
            s = "Delivery ID: " + deliveryTB.Text + "\n";
            e.Graphics.DrawString(s, new Font("Arial", 12), Brushes.Black, 100, 130);
            s = "Delivery Date: " + dateDTP.Text + "\n";
            e.Graphics.DrawString(s, new Font("Arial", 12), Brushes.Black, 100, 160);
            s = "Delivery Status: " + deliveryStatusTB.Text + "\n";
            e.Graphics.DrawString(s, new Font("Arial", 12), Brushes.Black, 500, 160);
            s = "Total Cost: " + totalCostTB.Text + "\n";
            e.Graphics.DrawString(s, new Font("Arial", 12), Brushes.Black, 100, 190);
            s = "Payment Status: " + paymentStatusTB.Text + "\n";
            e.Graphics.DrawString(s, new Font("Arial", 12), Brushes.Black, 500, 190);

            // Create a bitmap of the DataGridView
            Bitmap bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, dataGridView1.Bounds);

            // Draw the bitmap on the page
            e.Graphics.DrawImage(bmp, 0, 210);
                }
            }
        }
    
