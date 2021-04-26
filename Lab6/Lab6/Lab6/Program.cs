using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("**************** Default Constructor ******************");
            Customer customerobject1 = new Customer();
            Console.Write("Enter CustomerId   :");
            customerobject1.CustomerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name:");
            customerobject1.CustomerName = Console.ReadLine();
            Console.Write("Enter Address      :");
            customerobject1.Address = Console.ReadLine();
            Console.Write("Enter City         :");
            customerobject1.City = Console.ReadLine();
            Console.Write("Enter Phone        :");
            customerobject1.Phone = Console.ReadLine();
            Console.Write("Enter Credit Limit :");
            customerobject1.CreditLimit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*************** Parameterized Constructor ***************");
            Console.Write("Enter CustomerId   :");
            int CustomerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Customer Name:");
            string CustomerName = Console.ReadLine();
            Console.Write("Enter Address      :");
            string Address = Console.ReadLine();
            Console.Write("Enter City         :");
            string City = Console.ReadLine();
            Console.Write("Enter Phone        :");
            string Phone = Console.ReadLine();
            Console.Write("Enter Credit Limit :");
            double CreditLimit = Convert.ToDouble(Console.ReadLine());
            Customer customerobject2 = new Customer(CustomerID, CustomerName, Address, City, Phone, CreditLimit);
            Console.ReadLine();   
        }
    }
}
