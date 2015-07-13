using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMui
{
    public class Savings :Account
    {
        private const double _interestRate = 1;
                


        public double InterestRate
        {
            get { return _interestRate; }
        }

        
        public Savings()
        {

        }
                

        public void PayInterest ()
        {
            
        }

    }
}
