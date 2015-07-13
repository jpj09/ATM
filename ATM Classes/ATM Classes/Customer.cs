using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMui
{
    public class Customer 
    {
        private string _name;
        private double _pinNumber;



        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double PinNumber
        {
            get { return _pinNumber; }
            set { _pinNumber = value; }
        }



        public Customer()
        {

        }

        public Customer(string name,double pinNumber)
        {
            _name = name;
            _pinNumber = pinNumber;
        }





    }
}
