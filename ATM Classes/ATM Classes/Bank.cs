using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMui
{
    public class Bank : Account 
    {
        private const double _maximumTopUp = 20000;
        private const double _refillAmount = 5000;

        public double MaximumTopUp
        {
            get { return _maximumTopUp; }
            
        }

        public double RefillAmount
        {
            get { return _refillAmount; }
        }

        

        public Bank()
        {

        }

        public Bank(string AccountType,string PinNumber, double AccountNumber, double AccountBalance) :base(AccountType,PinNumber,AccountNumber,AccountBalance)
        { 
        
        }



    }
}
