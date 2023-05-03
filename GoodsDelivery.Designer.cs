namespace VKN
{
    partial class GoodsDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.orderTB = new System.Windows.Forms.TextBox();
            this.totalCostTB = new System.Windows.Forms.TextBox();
            this.deliveryStatusTB = new System.Windows.Forms.TextBox();
            this.paymentStatusTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateDTP = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.printB = new System.Windows.Forms.Button();
            this.saveB = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.deliveryTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderTB
            // 
            this.orderTB.Location = new System.Drawing.Point(210, 23);
            this.orderTB.Name = "orderTB";
            this.orderTB.Size = new System.Drawing.Size(246, 22);
            this.orderTB.TabIndex = 0;
            // 
            // totalCostTB
            // 
            this.totalCostTB.Location = new System.Drawing.Point(210, 166);
            this.totalCostTB.Name = "totalCostTB";
            this.totalCostTB.Size = new System.Drawing.Size(246, 22);
            this.totalCostTB.TabIndex = 2;
            // 
            // deliveryStatusTB
            // 
            this.deliveryStatusTB.Location = new System.Drawing.Point(566, 117);
            this.deliveryStatusTB.Name = "deliveryStatusTB";
            this.deliveryStatusTB.Size = new System.Drawing.Size(155, 22);
            this.deliveryStatusTB.TabIndex = 3;
            // 
            // paymentStatusTB
            // 
            this.paymentStatusTB.Location = new System.Drawing.Point(566, 169);
            this.paymentStatusTB.Name = "paymentStatusTB";
            this.paymentStatusTB.Size = new System.Drawing.Size(155, 22);
            this.paymentStatusTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "OrderID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "DeliveryDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "TotalCost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Delivery status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Payment status";
            // 
            // dateDTP
            // 
            this.dateDTP.Location = new System.Drawing.Point(210, 117);
            this.dateDTP.Name = "dateDTP";
            this.dateDTP.Size = new System.Drawing.Size(246, 22);
            this.dateDTP.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 194);
            this.dataGridView1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 44);
            this.button1.TabIndex = 12;
            this.button1.Text = "View order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printB
            // 
            this.printB.Location = new System.Drawing.Point(444, 436);
            this.printB.Name = "printB";
            this.printB.Size = new System.Drawing.Size(144, 44);
            this.printB.TabIndex = 13;
            this.printB.Text = "Print";
            this.printB.UseVisualStyleBackColor = true;
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(621, 436);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(144, 44);
            this.saveB.TabIndex = 14;
            this.saveB.Text = "Save";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "DeliveryID";
            // 
            // deliveryTB
            // 
            this.deliveryTB.Location = new System.Drawing.Point(210, 68);
            this.deliveryTB.Name = "deliveryTB";
            this.deliveryTB.Size = new System.Drawing.Size(246, 22);
            this.deliveryTB.TabIndex = 15;
            // 
            // GoodsDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deliveryTB);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.printB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateDTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paymentStatusTB);
            this.Controls.Add(this.deliveryStatusTB);
            this.Controls.Add(this.totalCostTB);
            this.Controls.Add(this.orderTB);
            this.Name = "GoodsDelivery";
            this.Text = "GoodsDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox orderTB;
        private System.Windows.Forms.TextBox totalCostTB;
        private System.Windows.Forms.TextBox deliveryStatusTB;
        private System.Windows.Forms.TextBox paymentStatusTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateDTP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button printB;
        private System.Windows.Forms.Button saveB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deliveryTB;
    }
}