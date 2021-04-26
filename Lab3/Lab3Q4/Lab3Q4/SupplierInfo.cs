using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Q4
{
    class SupplierInfo
    {
        Supplier supplier = new Supplier();
        public void AcceptDetails()
        {
            Console.Write("Enter Supplier Id:");
            supplier.SupplierId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Supplier Name:");
            supplier.SupplierName = Console.ReadLine();
            Console.Write("Enter City:");
            supplier.City = Console.ReadLine();
            Console.Write("Enter Phone Number:");
            supplier.PhoneNo = Console.ReadLine();
            Console.Write("Enter Email:");
            supplier.Email = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Supplier Details:");
            Console.WriteLine($"Supplier ID:{supplier.SupplierId}\nSupplier Name:{supplier.SupplierName}\nCity:{supplier.City}\nPhone Number:{supplier.PhoneNo}\nEmail:{supplier.Email}");

        }
    }
}
