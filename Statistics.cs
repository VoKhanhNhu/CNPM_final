using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DataTable = System.Data.DataTable;
using LicenseContext = OfficeOpenXml.LicenseContext;
using ExcelDataReader;
using ExcelDataReader.Exceptions;
using System.Drawing.Printing;
using Font = System.Drawing.Font;

namespace VKN
{
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        public int CheckGoodsOut(string ID, int month)
        {
            int re = 0;
            var fileInfo = new FileInfo(@"D:\NT106\VKN\order.xlsx");
            using (var package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                // Duyệt qua từng dòng để kiểm tra thông tin đăng nhập
                for (int row = 2; row <= rowCount; row++)
                {
                    DateTime d = (DateTime) worksheet.Cells[row, 2].Value;
                    if (ID == worksheet.Cells[row, 3].Value?.ToString() && month == d.Month && d.Year == 2023) 
                        re += int.Parse(worksheet.Cells[row, 5].Value.ToString());
                }
            }
            return re;
        }

        public void GenerateMonthlyReport(object month)
        {
            var fileInfo = new FileInfo(@"D:\NT106\VKN\goods.xlsx");
            using (var package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets["Sheet1"];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;
                
                int m = int.Parse((string)month);

                int bestSaler = 0;
                long revenue = 0;
                DataTable goodsOut = new DataTable();
                goodsOut.Columns.Add("Goods ID");
                goodsOut.Columns.Add("Goods Name");
                goodsOut.Columns.Add("This month's sale");
                // Duyệt qua từng dòng để kiểm tra thông tin đăng nhập
                for (int row = 2; row <= rowCount; row++)
                {
                    int x = CheckGoodsOut(worksheet.Cells[row, 1].Value?.ToString(), m);
                    int check = Math.Max(bestSaler, x);
                    revenue += x * long.Parse(worksheet.Cells[row, 4].Value?.ToString());
                    goodsOut.Rows.Add(worksheet.Cells[row, 1].Value?.ToString(), worksheet.Cells[row, 2].Value?.ToString(), x.ToString());
                    if (check != bestSaler && check != 0)
                    {
                        textBox1.Text = "This month's best saler: " + worksheet.Cells[row, 2].Value?.ToString() + "(Goods ID: " + worksheet.Cells[row, 1].Value?.ToString() + ") with " + x.ToString() + " sales!";
                        bestSaler = check;
                    }
                }
                if (textBox1.Text == "") textBox1.Text = "There's no sales in this month";
                textBox2.Text = "This month's revenue: " + revenue;
                goodsOutDGV.DataSource = goodsOut;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            GenerateMonthlyReport(comboBox1.SelectedItem);
        }
    }
}
