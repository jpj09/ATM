using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ATMui
{
    public class checkingAccounts : CollectionBase
    {
    
        public checkingAccounts()
        {
            

        }

        public void AddAccount(Checking c)
        {
            
            List.Add(c);
        }

        
    }
}
