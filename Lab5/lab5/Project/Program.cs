using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main()
        {
            ICICI icici1 = new ICICI();
            icici1.AccountType = BankAccountTypeEnum.Saving;
            icici1.deposit(50000);
            ICICI icici2 = new ICICI();
            icici2.AccountType = BankAccountTypeEnum.Current;
            icici2.deposit(20000);
            Console.WriteLine("Balance" + icici1.GetBalance());
            Console.WriteLine("Balance" + icici2.GetBalance());
            Console.ReadLine();

        }
    }
}
