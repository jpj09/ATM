namespace ATMui
{
    partial class AdminForm
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
            this.Refillbutton = new System.Windows.Forms.Button();
            this.PayInterestbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ListAccountsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Refillbutton
            // 
            this.Refillbutton.Location = new System.Drawing.Point(39, 236);
            this.Refillbutton.Name = "Refillbutton";
            this.Refillbutton.Size = new System.Drawing.Size(75, 23);
            this.Refillbutton.TabIndex = 0;
            this.Refillbutton.Text = "Refill";
            this.Refillbutton.UseVisualStyleBackColor = true;
            this.Refillbutton.Click += new System.EventHandler(this.Refillbutton_Click);
            // 
            // PayInterestbutton
            // 
            this.PayInterestbutton.Location = new System.Drawing.Point(169, 236);
            this.PayInterestbutton.Name = "PayInterestbutton";
            this.PayInterestbutton.Size = new System.Drawing.Size(75, 23);
            this.PayInterestbutton.TabIndex = 1;
            this.PayInterestbutton.Text = "Pay Interest";
            this.PayInterestbutton.UseVisualStyleBackColor = true;
            this.PayInterestbutton.Click += new System.EventHandler(this.PayInterestbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(69, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 147);
            this.listBox1.TabIndex = 2;
            // 
            // ListAccountsButton
            // 
            this.ListAccountsButton.Location = new System.Drawing.Point(304, 235);
            this.ListAccountsButton.Name = "ListAccountsButton";
            this.ListAccountsButton.Size = new System.Drawing.Size(91, 23);
            this.ListAccountsButton.TabIndex = 3;
            this.ListAccountsButton.Text = "List Accounts";
            this.ListAccountsButton.UseVisualStyleBackColor = true;
            this.ListAccountsButton.Click += new System.EventHandler(this.ListAccountsButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 324);
            this.Controls.Add(this.ListAccountsButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PayInterestbutton);
            this.Controls.Add(this.Refillbutton);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Refillbutton;
        private System.Windows.Forms.Button PayInterestbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button ListAccountsButton;
    }
}