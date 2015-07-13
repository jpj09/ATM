namespace ATMui
{
    partial class WithDraw
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
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.CheckingradioButton = new System.Windows.Forms.RadioButton();
            this.SavingsradioButton = new System.Windows.Forms.RadioButton();
            this.WithDrawbutton = new System.Windows.Forms.Button();
            this.GoBackbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Location = new System.Drawing.Point(29, 159);
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.Size = new System.Drawing.Size(100, 20);
            this.AmounttextBox.TabIndex = 0;
            this.AmounttextBox.TextChanged += new System.EventHandler(this.AmounttextBox_TextChanged);
            // 
            // CheckingradioButton
            // 
            this.CheckingradioButton.AutoSize = true;
            this.CheckingradioButton.Location = new System.Drawing.Point(29, 38);
            this.CheckingradioButton.Name = "CheckingradioButton";
            this.CheckingradioButton.Size = new System.Drawing.Size(119, 17);
            this.CheckingradioButton.TabIndex = 1;
            this.CheckingradioButton.TabStop = true;
            this.CheckingradioButton.Text = "Chekcking Account";
            this.CheckingradioButton.UseVisualStyleBackColor = true;
            this.CheckingradioButton.CheckedChanged += new System.EventHandler(this.CheckingradioButton_CheckedChanged);
            // 
            // SavingsradioButton
            // 
            this.SavingsradioButton.AutoSize = true;
            this.SavingsradioButton.Location = new System.Drawing.Point(29, 74);
            this.SavingsradioButton.Name = "SavingsradioButton";
            this.SavingsradioButton.Size = new System.Drawing.Size(106, 17);
            this.SavingsradioButton.TabIndex = 2;
            this.SavingsradioButton.TabStop = true;
            this.SavingsradioButton.Text = "Savings Account";
            this.SavingsradioButton.UseVisualStyleBackColor = true;
            this.SavingsradioButton.CheckedChanged += new System.EventHandler(this.SavingsradioButton_CheckedChanged);
            // 
            // WithDrawbutton
            // 
            this.WithDrawbutton.Location = new System.Drawing.Point(32, 209);
            this.WithDrawbutton.Name = "WithDrawbutton";
            this.WithDrawbutton.Size = new System.Drawing.Size(75, 23);
            this.WithDrawbutton.TabIndex = 3;
            this.WithDrawbutton.Text = "WithDraw";
            this.WithDrawbutton.UseVisualStyleBackColor = true;
            this.WithDrawbutton.Click += new System.EventHandler(this.WithDrawbutton_Click);
            // 
            // GoBackbutton
            // 
            this.GoBackbutton.Location = new System.Drawing.Point(174, 209);
            this.GoBackbutton.Name = "GoBackbutton";
            this.GoBackbutton.Size = new System.Drawing.Size(75, 23);
            this.GoBackbutton.TabIndex = 4;
            this.GoBackbutton.Text = "Go Back";
            this.GoBackbutton.UseVisualStyleBackColor = true;
            this.GoBackbutton.Click += new System.EventHandler(this.GoBackbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select wich account to withdraw from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Amount";
            // 
            // WithDraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBackbutton);
            this.Controls.Add(this.WithDrawbutton);
            this.Controls.Add(this.SavingsradioButton);
            this.Controls.Add(this.CheckingradioButton);
            this.Controls.Add(this.AmounttextBox);
            this.Name = "WithDraw";
            this.Text = "WithDraw";
            this.Load += new System.EventHandler(this.WithDraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AmounttextBox;
        private System.Windows.Forms.RadioButton CheckingradioButton;
        private System.Windows.Forms.RadioButton SavingsradioButton;
        private System.Windows.Forms.Button WithDrawbutton;
        private System.Windows.Forms.Button GoBackbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}