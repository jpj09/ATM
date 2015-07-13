using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ATMui
{
    public partial class AdminForm : Form
    {
        ATMManager _atmm;

        public AdminForm(ATMManager ATMM)
        {
            _atmm = ATMM ;

            InitializeComponent();
            
        }

        private void Refillbutton_Click(object sender, EventArgs e)
        {
            try
            {
                _atmm.RefillATM();
                MessageBox.Show("ATM Refilled");
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void PayInterestbutton_Click(object sender, EventArgs e)
        {
            try
            {
                _atmm.PayInterest();
                MessageBox.Show("Inteest Paid");
            }
            catch
            {
                MessageBox.Show("something went wrong");
            }

        }

        private void ListAccountsButton_Click(object sender, EventArgs e)
        {
            string path = @"c:\Accounts.txt";           
            StreamReader sr = new StreamReader(path);
            {
                               
                while (!sr.EndOfStream )
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
              
            }
            sr.Close();

        }



        



    }
}

        
