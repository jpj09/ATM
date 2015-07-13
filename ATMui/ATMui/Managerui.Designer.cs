namespace ATMui
{
    partial class Managerui
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
            this.DepositButton = new System.Windows.Forms.Button();
            this.WithDrawButton = new System.Windows.Forms.Button();
            this.Transferbutton = new System.Windows.Forms.Button();
            this.PayBilbutton = new System.Windows.Forms.Button();
            this.Exitbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DepositButton
            // 
            this.DepositButton.Location = new System.Drawing.Point(12, 119);
            this.DepositButton.Name = "DepositButton";
            this.DepositButton.Size = new System.Drawing.Size(75, 23);
            this.DepositButton.TabIndex = 0;
            this.DepositButton.Text = "Deposit";
            this.DepositButton.UseVisualStyleBackColor = true;
            this.DepositButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // WithDrawButton
            // 
            this.WithDrawButton.Location = new System.Drawing.Point(12, 160);
            this.WithDrawButton.Name = "WithDrawButton";
            this.WithDrawButton.Size = new System.Drawing.Size(75, 23);
            this.WithDrawButton.TabIndex = 1;
            this.WithDrawButton.Text = "WithDraw";
            this.WithDrawButton.UseVisualStyleBackColor = true;
            this.WithDrawButton.Click += new System.EventHandler(this.WithDrawButton_Click);
            // 
            // Transferbutton
            // 
            this.Transferbutton.Location = new System.Drawing.Point(188, 119);
            this.Transferbutton.Name = "Transferbutton";
            this.Transferbutton.Size = new System.Drawing.Size(75, 23);
            this.Transferbutton.TabIndex = 2;
            this.Transferbutton.Text = "Transfer Money";
            this.Transferbutton.UseVisualStyleBackColor = true;
            this.Transferbutton.Click += new System.EventHandler(this.Transferbutton_Click);
            // 
            // PayBilbutton
            // 
            this.PayBilbutton.Location = new System.Drawing.Point(188, 159);
            this.PayBilbutton.Name = "PayBilbutton";
            this.PayBilbutton.Size = new System.Drawing.Size(75, 23);
            this.PayBilbutton.TabIndex = 3;
            this.PayBilbutton.Text = "Pay Bill";
            this.PayBilbutton.UseVisualStyleBackColor = true;
            this.PayBilbutton.Click += new System.EventHandler(this.PayBilbutton_Click);
            // 
            // Exitbutton1
            // 
            this.Exitbutton1.Location = new System.Drawing.Point(98, 207);
            this.Exitbutton1.Name = "Exitbutton1";
            this.Exitbutton1.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton1.TabIndex = 4;
            this.Exitbutton1.Text = "Exit";
            this.Exitbutton1.UseVisualStyleBackColor = true;
            this.Exitbutton1.Click += new System.EventHandler(this.Exitbutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to the ATM\r\n\r\nPlease choose action";
            // 
            // Managerui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exitbutton1);
            this.Controls.Add(this.PayBilbutton);
            this.Controls.Add(this.Transferbutton);
            this.Controls.Add(this.WithDrawButton);
            this.Controls.Add(this.DepositButton);
            this.Name = "Managerui";
            this.Text = "Managerui";
            this.Load += new System.EventHandler(this.Managerui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DepositButton;
        private System.Windows.Forms.Button WithDrawButton;
        private System.Windows.Forms.Button Transferbutton;
        private System.Windows.Forms.Button PayBilbutton;
        private System.Windows.Forms.Button Exitbutton1;
        private System.Windows.Forms.Label label1;
    }
}