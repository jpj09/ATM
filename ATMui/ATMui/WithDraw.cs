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
    public partial class WithDraw : Form
    {
        ATMManager _atmm;


        string _pin, _selectedAccount;
        double _amount;

        public WithDraw(string InccPin, ATMManager ATMM)
        {
            _pin = InccPin;
            _atmm = ATMM;
            InitializeComponent();
        }

        private void WithDraw_Load(object sender, EventArgs e)
        {

        }

        private void CheckingradioButton_CheckedChanged(object sender, EventArgs e)
        {
            _selectedAccount = "C";
        }

        private void SavingsradioButton_CheckedChanged(object sender, EventArgs e)
        {
            _selectedAccount = "S";
        }

        private void AmounttextBox_TextChanged(object sender, EventArgs e)
        {
            _amount = Double.Parse(AmounttextBox.Text);
        }

        private void WithDrawbutton_Click(object sender, EventArgs e)
        {
            if (_selectedAccount == "C")
            {
                _atmm.WithDrawChecking(_pin, _amount);
                
                    string curbalance;
                    curbalance = Convert.ToString(_atmm.DisplayCurrentBalance(_pin, "C"));
                    MessageBox.Show("Your Checking Balance is" + curbalance);               
            }
            else if (_selectedAccount == "S")
            {
                _atmm.WithdrawSavings(_pin, _amount);
                string curbalance;
                curbalance = Convert.ToString(_atmm.DisplayCurrentBalance(_pin, "S"));
                MessageBox.Show("Your Savings account Balance is" + curbalance);
            }
        }

        private void GoBackbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
