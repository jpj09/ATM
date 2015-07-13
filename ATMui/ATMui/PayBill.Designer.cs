namespace ATMui
{
    partial class PayBill
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PayBillButton = new System.Windows.Forms.Button();
            this.GoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 91);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service cost of $1,25 extra will be charged.\r\n\r\nPayments are made from checking a" +
    "ccount\r\n\r\ndon\'t forget to put bill in envelope\r\n\r\ndo NOT put money in envelope";
            // 
            // PayBillButton
            // 
            this.PayBillButton.Location = new System.Drawing.Point(160, 175);
            this.PayBillButton.Name = "PayBillButton";
            this.PayBillButton.Size = new System.Drawing.Size(75, 23);
            this.PayBillButton.TabIndex = 2;
            this.PayBillButton.Text = "Pay Bill";
            this.PayBillButton.UseVisualStyleBackColor = true;
            this.PayBillButton.Click += new System.EventHandler(this.PayBillButton_Click);
            // 
            // GoBack
            // 
            this.GoBack.Location = new System.Drawing.Point(160, 227);
            this.GoBack.Name = "GoBack";
            this.GoBack.Size = new System.Drawing.Size(75, 23);
            this.GoBack.TabIndex = 3;
            this.GoBack.Text = "GoBack";
            this.GoBack.UseVisualStyleBackColor = true;
            this.GoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // PayBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.GoBack);
            this.Controls.Add(this.PayBillButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "PayBill";
            this.Text = "PayBill";
            this.Load += new System.EventHandler(this.PayBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PayBillButton;
        private System.Windows.Forms.Button GoBack;
    }
}