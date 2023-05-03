namespace VKN
{
    partial class LogInSaler
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
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.signB = new System.Windows.Forms.Button();
            this.logB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "LOG IN FORM FOR SALER";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(218, 69);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(348, 22);
            this.nameTB.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name:";
            // 
            // passTB
            // 
            this.passTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passTB.Location = new System.Drawing.Point(218, 131);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(348, 22);
            this.passTB.TabIndex = 9;
            // 
            // signB
            // 
            this.signB.Location = new System.Drawing.Point(427, 182);
            this.signB.Name = "signB";
            this.signB.Size = new System.Drawing.Size(140, 57);
            this.signB.TabIndex = 8;
            this.signB.Text = "Sign in";
            this.signB.UseVisualStyleBackColor = true;
            this.signB.Click += new System.EventHandler(this.signB_Click);
            // 
            // logB
            // 
            this.logB.Location = new System.Drawing.Point(223, 182);
            this.logB.Name = "logB";
            this.logB.Size = new System.Drawing.Size(140, 57);
            this.logB.TabIndex = 7;
            this.logB.Text = "Log in";
            this.logB.UseVisualStyleBackColor = true;
            this.logB.Click += new System.EventHandler(this.logB_Click);
            // 
            // LogInSaler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 282);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.signB);
            this.Controls.Add(this.logB);
            this.Name = "LogInSaler";
            this.Text = "LogInSaler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button signB;
        private System.Windows.Forms.Button logB;
    }
}