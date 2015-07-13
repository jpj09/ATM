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
    public partial class PayBill : Form
    {
        string _pin;
        double _amount;
        ATMManager _atmm;  

        public PayBill(string Pin, ATMManager ATMM)
        {
            _pin = Pin;
            _atmm = ATMM;
            InitializeComponent();
        }

        private void PayBill_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double parseddvalue;
            if (double.TryParse(textBox1.Text, out parseddvalue))
            {
                _amount = parseddvalue;     //Double.Parse(textBox1.Text);
            }
        }

        private void PayBillButton_Click(object sender, EventArgs e)
        {
            _atmm.PayBill(_pin,_amount);
            string curbalance;
            curbalance = Convert.ToString(_atmm.DisplayCurrentBalance(_pin, "C"));
            MessageBox.Show("Your Checking Balance is" + curbalance);
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
