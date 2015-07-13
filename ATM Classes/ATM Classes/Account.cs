using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMui
{
    public class Account
    {      
        private double _accountBalance, _accountNumber, _maximumWithDrawal, _maximumTransferAmount;

        private string _accountType, _pinNumbers;        

        /// <summary>
        /// PROPERTIES
        /// </summary>

        public string PinNumbers
        {
            get { return _pinNumbers; }
            set {_pinNumbers = value;}
        }
        public double AccountBalance
        {
            get { return _accountBalance; }
            set { _accountBalance = value; }
        }

        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }
       
       public double AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

       

        public double MaximumWithDrawal
        {
            get { return _maximumWithDrawal; }
            set { _maximumWithDrawal = value; }
        }

        public double MaximumTransferAmount
        {
            get { return _maximumTransferAmount; }
            set { _maximumTransferAmount = value; }
        }

        /// <summary>
        /// END OF PROPERTIES
        /// </summary>
        

        //
        // CONSTRUCTORS
        //

        public  Account ()
        {
         

        }

        public Account(string AccountType, string PinNumber, double AccountNumber, double AccountBalance)
        {
            _accountType = AccountType;
            _pinNumbers = PinNumber;
            _accountNumber = AccountNumber;
            _accountBalance = AccountBalance;
            
        }
              
        //
        //END CONSTRUCTORS
        //

        //
        //METHODS
        //


        public void TransferOut(double amount) //From checking to savings
        {
            
                        
        }

        public void TransferIn(double amount) // from savings to checkings
        {
         
        }

        public string GetPin()
        {
            return _pinNumbers;
        }

        public double GetAccountNumber()
        {
            return _accountNumber;
        }
                


        public double GetBalance()
        {
            
            return _accountBalance;
        }




    }
}
