using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Simulation_EC
{
    class BankAccount
    {
        private decimal balance; 

        //Construct 
        public BankAccount(decimal startingBalance)
        {
            balance = startingBalance;
        }
        
        // Balance property 
        public decimal Balance
        {
            get { return balance; }
        }

        // Desposit 
        public void Deposit (decimal amount)
        {
            balance += amount; 
        }

        // Withdraw 
        public void Withdraw (decimal amount)
        {
            balance -= amount; 
        }
    }
}
