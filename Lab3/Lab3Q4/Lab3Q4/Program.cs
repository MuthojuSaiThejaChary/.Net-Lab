using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Q4
{
    class Program
    {
        static void Main(string[] args)
        {

            SupplierInfo supplier = new SupplierInfo();
            supplier.AcceptDetails();
            supplier.DisplayDetails();
            Console.ReadLine();
        }
    }
}
