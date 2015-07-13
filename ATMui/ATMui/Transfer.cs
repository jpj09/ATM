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
    public partial class Transfer : Form
    {
        ATMManager _atmm;
        string _pin, _selectedAccount;
        double _amount;

        public Transfer(string Pin, ATMManager ATMM)
        {
            _pin = Pin;
            _atmm = ATMM;

            InitializeComponent();
        }

        private void Transfer_Load(object sender, EventArgs e)
        {

        }

        private void fromchecktosavradioButton_CheckedChanged(object sender, EventArgs e)
        {
            _selectedAccount = "S";
        }

        private void fromsavtocheckradioButton_CheckedChanged(object sender, EventArgs e)
        {
            _selectedAccount = "C";
        }

        private void AmounttextBox_TextChanged(object sender, EventArgs e)
        {
            _amount = Double.Parse(AmounttextBox.Text);
        }

        private void Transferbutton_Click(object sender, EventArgs e)
        {
            if(_selectedAccount == "C")
            {
                _atmm.TransferSavToChk(_pin,_amount);
                string curbalance;
                curbalance = Convert.ToString(_atmm.DisplayCurrentBalance(_pin, "C"));
                MessageBox.Show( "Your Checking Balance is"+curbalance);
            }

            if(_selectedAccount == "S")
            {
                _atmm.TransferChkToSav(_pin, _amount);
                string curbalance;
                curbalance = Convert.ToString(_atmm.DisplayCurrentBalance(_pin, "S"));
                MessageBox.Show("Your Savings Account Balance is"+curbalance);

            }

        }

        private void GoBackbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
