using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Q2
{
    class ProductTest
    {
        static void Main(string[] args)
        {   

            ProductMock product = new ProductMock();
            Console.WriteLine("Default Constructor:");
            Console.Write("Enter ProductID:");
            product.ProductID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ProductName:");
            product.ProductName = Console.ReadLine();
            Console.Write("Enter Product Price:");
            product.Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Parameterized Constructor");
            Console.Write("Enter ProductID:");
            int productID =Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Product Name:");
            string productName = Console.ReadLine();
            Console.Write("Enter Price:");
            double price = Convert.ToDouble(Console.ReadLine());
            ProductMock product1 = new ProductMock(productID,productName,price);
            DisplayDetails(product);
            DisplayDetails(product1);

            Console.ReadLine();
        }
        static void DisplayDetails(ProductMock obj)
        {
            Console.WriteLine("----------PRODUCT DETAILS-----------");
            Console.WriteLine($"ProductID:{obj.ProductID}\nProduct Name:{obj.ProductName}\nProduct Price:{obj.Price}");
        }
    }
}
