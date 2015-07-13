using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ATMui
{
    public class ATMManager
    {
        checkingAccounts chkacc = new checkingAccounts();
        savingsAccounts savacc = new savingsAccounts();
        BankAccounts bnkacc = new BankAccounts();


        private const double _refillAmount = 5000;
        double _banknumb, _customers, _checkingAccounts, _savingsAccounts, _currentAccountBalance;


        //
        //CONSTRUCTORS
        //
        public ATMManager()
        {
                      
        }
        //
        //END CONSTRUCTORS
        //


        //
        //PROPERTIES
        //
        public double BankNumb 
        {
            get { return _banknumb; }
            set { _banknumb = value; }
        }

        public double Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        public double CheckingAccounts
        {
            get { return _checkingAccounts; }
            set { _checkingAccounts = value; }

        }

        public double SavingsAccounts
        {
            get { return _savingsAccounts; }
            set { _savingsAccounts = value; }
        }

        public double CurrentAccountBalance
        {
            get { return _currentAccountBalance; }
            set { _currentAccountBalance = value; }
        }
        
        //
        //END PROPERTIES
        //
                               

        //
        //METHODS
        //

        public bool ValidateUser(string name , double pin)
        {            
            return true;
        }


        public bool TransferChkToSav(string Pin, double Amount)
        {            
            foreach (Checking c in chkacc)
            {
                if (c.PinNumbers == Pin && c.AccountType == "C")
                {
                    if (c.AccountBalance >= Amount)
                    {
                        c.AccountBalance -= Amount;

                        foreach (Savings s in savacc)
                        {
                            if (s.PinNumbers == Pin && s.AccountType == "S")
                            {
                                s.AccountBalance += Amount;
                            }
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Not enough money in account");
                    }
                }
            }
            WriteAccounts();
            return true;
        }

        public bool TransferSavToChk(string Pin, double Amount)
        {

            foreach (Checking c in chkacc)
            {
                if (c.PinNumbers == Pin && c.AccountType == "C")
                {

                    if (c.AccountBalance >= Amount)
                    {
                        c.AccountBalance += Amount;
                        foreach (Savings s in savacc)
                        {
                            if (s.PinNumbers == Pin && s.AccountType == "S")
                            {
                                s.AccountBalance -= Amount;
                            }
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Not enough money in account");
                    }
                }
            }

            
            WriteAccounts();
            return true;
        }

        public double DisplayCurrentBalance(string Pin, string AccountType)
        {
            if (AccountType == "C")
            {
                foreach (Checking c in chkacc)
                {
                    if (c.PinNumbers == Pin && c.AccountType == "C")
                    {
                        _currentAccountBalance = c.AccountBalance;
                    }
                }
            }
            else if (AccountType == "S")
            {
                foreach (Savings c in savacc)
                {
                    if (c.PinNumbers == Pin && c.AccountType == "S")
                    {
                        _currentAccountBalance = c.AccountBalance;
                    }
                }
            }
            return _currentAccountBalance;            
        }

        public bool WithDrawChecking(string pin , double amount)
        {
            foreach (Checking c in chkacc)
            {
                if (c.PinNumbers == pin && c.AccountType == "C")
                {
                    if (c.AccountBalance >= amount)
                    {
                        c.AccountBalance -= amount;
                        foreach (Bank b in bnkacc)
                        {
                            b.AccountBalance -= amount;
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Not enough money in account");
                    }
                }  
            }
            
            WriteAccounts();
            
            return true;
        }


        public bool WithdrawSavings(string pin , double amount)
        {
            foreach (Savings c in savacc)
            {
                if (c.PinNumbers == pin && c.AccountType == "S")
                {
                    if (c.AccountBalance >= amount)
                    {
                        c.AccountBalance -= amount;

                        foreach (Bank b in bnkacc)
                        {
                            b.AccountBalance -= amount;
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Not enough money in account");
                    }
                }
            }
            WriteAccounts();
            return true;    
        }

        public void RefillATM()
        {
            foreach (Bank b in bnkacc )
            {                
                    if (b.AccountType == "B" && b.AccountBalance <= 15000)
                    {
                        b.AccountBalance += _refillAmount;
                    }
                
                    else 
                    {
                    System.Windows.Forms.MessageBox.Show("Too much money in bank");
                    }
            }
            WriteAccounts(); 
        }

        public void PayInterest()
        {
            foreach (Savings s in savacc)
            {                
                    double rdn = 0;
                    rdn = s.AccountBalance * 0.01;
                    s.AccountBalance = s.AccountBalance + (s.AccountBalance * 0.01) ;
                    
                    foreach (Bank b in bnkacc)
                    {
                        b.AccountBalance -=  rdn ;
                    }                
            }
            WriteAccounts();
        }

        public bool DepositCheking(string pin , double amount)
        {
            foreach (Checking c in chkacc)
                        {
                            if (c.PinNumbers == pin && c.AccountType == "C")
                            {         
                                c.AccountBalance += amount;
                                foreach (Bank b in bnkacc)
                                {
                                    b.AccountBalance += amount;
                                }
                            }
                        }     
                        WriteAccounts();             
            return true;
        }

        public bool DepositSavings(string pin, double amount)
        {
            foreach (Savings c in savacc)
            {
                if (c.PinNumbers == pin && c.AccountType == "S")
                {
                    c.AccountBalance += amount;
                    foreach (Bank b in bnkacc)
                    {
                        b.AccountBalance += amount;
                    }
                }
            }            
            WriteAccounts();
            return true;
        }

        public bool PayBill(string pin ,double amount)
        {
            foreach (Checking c in chkacc)
            {
                if (c.PinNumbers == pin && c.AccountType == "C")
                {
                    c.AccountBalance = (c.AccountBalance - amount) - 1.25;

                    foreach (Bank b in bnkacc)
                    {
                        b.AccountBalance = b.AccountBalance + amount + 1.25;
                    }

                }
            }
            WriteAccounts();
            return true;
        }

   
        public bool WriteAccounts ()
        {
            string path = @"c:\Accounts.txt";
                FileStream fm = new FileStream(path, FileMode.Create);
                using (StreamWriter sw = new StreamWriter(fm))
                {
                    foreach (Bank c in bnkacc)
                    {
                        sw.WriteLine(c.AccountType + "," + Convert.ToString(c.GetPin()) + "," + Convert.ToString(c.GetAccountNumber()) + "," + Convert.ToString(c.AccountBalance));
                    }

                    foreach (Checking c in chkacc)
                    {
                        sw.WriteLine(c.AccountType + "," + Convert.ToString(c.GetPin()) + "," + Convert.ToString(c.GetAccountNumber()) + "," + Convert.ToString(c.AccountBalance));
                    }

                    foreach (Savings c in savacc)
                    {
                        sw.WriteLine(c.AccountType + "," + Convert.ToString(c.GetPin()) + "," + Convert.ToString(c.GetAccountNumber()) + "," + Convert.ToString(c.AccountBalance));
                    }                   

                }
            return true;
        }

        public bool ReadAccounts()
        {
            string path = @"c:\Accounts.txt";           
            StreamReader sr = new StreamReader(path);
            {
                string str = sr.ReadLine();
                
                while (str != null)
                {
                    string accounttype ="";
                    string pinnumb = "";
                    string accountnumb = "";
                    string accountbalance = "";                                                    
                                      
                    accounttype = str.Substring(0, 1);
                    pinnumb = str.Substring(2,4);
                    accountnumb = str.Substring(7,5);
                    accountbalance = str.Substring(13);

                    if (accounttype == "C")
                    {
                        Checking a = new Checking();

                        a.AccountType = accounttype;
                        a.PinNumbers = pinnumb;
                        a.AccountNumber = Double.Parse(accountnumb);
                        a.AccountBalance = Double.Parse(accountbalance);

                        chkacc.AddAccount(a);
                    }

                    if (accounttype == "S")
                    {
                        Savings a = new Savings();
                        a.AccountType = accounttype;
                        a.PinNumbers = pinnumb;
                        a.AccountNumber = Double.Parse(accountnumb);
                        a.AccountBalance = Double.Parse(accountbalance);

                        savacc.AddAccount(a);
                    }


                    if (accounttype == "B")
                    {
                        Bank a = new Bank();
                        a.AccountType = accounttype;
                        a.PinNumbers = pinnumb;
                        a.AccountNumber = Double.Parse(accountnumb);
                        a.AccountBalance = Double.Parse(accountbalance);

                        bnkacc.AddAccount(a);
                    }   
                    str = sr.ReadLine();                    
                }
                sr.Close();
            }                             
            return true;
        }






    }
}
