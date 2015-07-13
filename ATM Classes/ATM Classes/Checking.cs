using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMui
{
   public class Checking : Account
    {
        private const double _billFee = 1.25;
        private const double _maximumBillAmount = 10000;
        
        
        public double BillFee
        {
            get { return _billFee; }            
        }

        public double MaximumBillAmount
        {
            get { return _maximumBillAmount; }
        }


        public Checking()
        {

        }

        public Checking(string AccountType,string PinNumber, double AccountNumber, double AccountBalance) :base(AccountType,PinNumber,AccountNumber,AccountBalance)
        { 
        
        }


        public void PayBill(double Amount)
        {
          

        }

    }
}
