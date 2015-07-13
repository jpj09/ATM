using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;




namespace ATMui
{
    public class savingsAccounts : CollectionBase
    {

        public savingsAccounts()
        {
          
        }

        public void AddAccount(Savings s)
        {
            List.Add(s);
        }


    }
}
