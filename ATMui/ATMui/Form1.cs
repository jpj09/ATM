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
    public partial class Form1 : Form
    {
       
        string _loginPin ,_userName;
        
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"c:\Customers.txt";

            
                StreamReader sr = new StreamReader(path);
                {
                    string str = sr.ReadLine();

                    while (str != null)
                    {
                        string[] password = str.Split(',');

                        _userName = password[0];
                        _loginPin = password[1];

                        //if (_userName == "Admin" && _loginPin == "Admin")
                        //{
                        //    ATMManager atmm = new ATMManager();
                        //    atmm.ReadAccounts();


                        //    AdminForm ad = new AdminForm(atmm);
                        //    ad.Show();

                        //}

                        if (_loginPin == PassWordtextBox.Text && _userName == UserNametextBox.Text)
                        {

                            if (_userName == "Admin" && _loginPin == "Admin")
                            {
                                ATMManager atmm = new ATMManager();
                                atmm.ReadAccounts();


                                AdminForm ad = new AdminForm(atmm);
                                ad.Show();
                                this.Hide();
                            }

                            else
                            {
                                Managerui mui = new Managerui(_loginPin);
                                mui.Show();
                                this.Hide();
                            }

                        }
                        str = sr.ReadLine();
                    }
                    sr.Close();
                }
            
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            


        }

        private void UserNametextBox_TextChanged(object sender, EventArgs e)
        {
            _userName = UserNametextBox.Text;
        }

        private void PassWordtextBox_TextChanged(object sender, EventArgs e)
        {
            _loginPin = PassWordtextBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
