namespace ATMui
{
    partial class Transfer
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
            this.fromchecktosavradioButton = new System.Windows.Forms.RadioButton();
            this.fromsavtocheckradioButton = new System.Windows.Forms.RadioButton();
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.Transferbutton = new System.Windows.Forms.Button();
            this.GoBackbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromchecktosavradioButton
            // 
            this.fromchecktosavradioButton.AutoSize = true;
            this.fromchecktosavradioButton.Location = new System.Drawing.Point(39, 72);
            this.fromchecktosavradioButton.Name = "fromchecktosavradioButton";
            this.fromchecktosavradioButton.Size = new System.Drawing.Size(188, 17);
            this.fromchecktosavradioButton.TabIndex = 0;
            this.fromchecktosavradioButton.TabStop = true;
            this.fromchecktosavradioButton.Text = "Transfer from Checking to Savings";
            this.fromchecktosavradioButton.UseVisualStyleBackColor = true;
            this.fromchecktosavradioButton.CheckedChanged += new System.EventHandler(this.fromchecktosavradioButton_CheckedChanged);
            // 
            // fromsavtocheckradioButton
            // 
            this.fromsavtocheckradioButton.AutoSize = true;
            this.fromsavtocheckradioButton.Location = new System.Drawing.Point(39, 113);
            this.fromsavtocheckradioButton.Name = "fromsavtocheckradioButton";
            this.fromsavtocheckradioButton.Size = new System.Drawing.Size(187, 17);
            this.fromsavtocheckradioButton.TabIndex = 1;
            this.fromsavtocheckradioButton.TabStop = true;
            this.fromsavtocheckradioButton.Text = "Transfer from Savings to Chekings";
            this.fromsavtocheckradioButton.UseVisualStyleBackColor = true;
            this.fromsavtocheckradioButton.CheckedChanged += new System.EventHandler(this.fromsavtocheckradioButton_CheckedChanged);
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Location = new System.Drawing.Point(39, 171);
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.Size = new System.Drawing.Size(100, 20);
            this.AmounttextBox.TabIndex = 2;
            this.AmounttextBox.TextChanged += new System.EventHandler(this.AmounttextBox_TextChanged);
            // 
            // Transferbutton
            // 
            this.Transferbutton.Location = new System.Drawing.Point(45, 227);
            this.Transferbutton.Name = "Transferbutton";
            this.Transferbutton.Size = new System.Drawing.Size(75, 23);
            this.Transferbutton.TabIndex = 3;
            this.Transferbutton.Text = "Transfer";
            this.Transferbutton.UseVisualStyleBackColor = true;
            this.Transferbutton.Click += new System.EventHandler(this.Transferbutton_Click);
            // 
            // GoBackbutton
            // 
            this.GoBackbutton.Location = new System.Drawing.Point(173, 227);
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
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Transfer Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Amount";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GoBackbutton);
            this.Controls.Add(this.Transferbutton);
            this.Controls.Add(this.AmounttextBox);
            this.Controls.Add(this.fromsavtocheckradioButton);
            this.Controls.Add(this.fromchecktosavradioButton);
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton fromchecktosavradioButton;
        private System.Windows.Forms.RadioButton fromsavtocheckradioButton;
        private System.Windows.Forms.TextBox AmounttextBox;
        private System.Windows.Forms.Button Transferbutton;
        private System.Windows.Forms.Button GoBackbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}