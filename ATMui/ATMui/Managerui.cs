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
    public partial class Managerui : Form
    {
        string _Pin;
        ATMManager _atmm;

        public Managerui(string incPin)
        {
            ATMManager atmm = new ATMManager();
            _Pin = incPin;
            _atmm = atmm ;
            atmm.ReadAccounts();
            InitializeComponent();

        }

        private void Managerui_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit dp = new Deposit(_Pin,_atmm );
            dp.ShowDialog();                

        }

        private void Exitbutton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WithDrawButton_Click(object sender, EventArgs e)
        {
            WithDraw wd = new WithDraw(_Pin, _atmm);
            wd.ShowDialog();
        }

        private void PayBilbutton_Click(object sender, EventArgs e)
        {
            PayBill pb = new PayBill(_Pin, _atmm);
            pb.ShowDialog();
        }

        private void Transferbutton_Click(object sender, EventArgs e)
        {
            Transfer tf = new Transfer(_Pin, _atmm);
            tf.ShowDialog();
        }
    }
}
