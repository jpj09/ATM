using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMui
{
    public partial class Deposit : Form
    {
        ATMManager _atmm;
        string _pin , _selectedAccount;
        double _amount;

        public Deposit(string InccPin, ATMManager ATMM )
        {
            _pin = InccPin;
            _atmm = ATMM;
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _selectedAccount = "C";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _selectedAccount = "S";
        }

        private void AmounttextBox1_TextChanged(object sender, EventArgs e)
        {           


            _amount = Double.Parse(AmounttextBox1.Text);
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            
            if (_selectedAccount == "C")
            {
                _atmm.DepositCheking(_pin,_amount);
                string curbalance;
                curbalance = Convert.ToString(_atmm.DisplayCurrentBalance(_pin, "C"));
                MessageBox.Show("Your Checking Balance is" + curbalance);
                
            }
            else if (_selectedAccount == "S")
            {
                _atmm.DepositSavings(_pin, _amount);
                string curbalance;
                curbalance = Convert.ToString(_atmm.DisplayCurrentBalance(_pin, "S"));
                MessageBox.Show("Your Saving Account Balance is" + curbalance);
                
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
