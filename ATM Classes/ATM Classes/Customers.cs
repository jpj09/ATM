using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ATMui
{
    public class Customers : CollectionBase
    {
        public Customers()
        {

        }

        public void AddCustomer(Customer c)
        {
            List.Add(c);
        }


    }
}
