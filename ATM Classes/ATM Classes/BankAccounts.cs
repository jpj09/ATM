using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ATMui
{
    public class BankAccounts : CollectionBase
    {
             public BankAccounts()
        {
            

        }

        public void AddAccount(Bank c)
        {
            
            List.Add(c);
        }


    }
}
