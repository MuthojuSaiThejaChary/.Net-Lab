using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class HSBC:BankAccount
    {
        public override double GetBalance()
        {
            throw new NotImplementedException();
        }
        public override bool Withdraw(double amount)
        {
            double balance = GetBalance();
            if (balance - amount >= 5000)
            {
                Console.WriteLine("Withdrawing");
            }

            return true;
        }
        public override bool Transfer(IBankAccount bankAccount, double amount)
        {
            double balance = GetBalance();
            if (balance -  >= 5000)
            {
                Console.WriteLine("Transfer Possible");
            }
            return true;
        }

    }
}
