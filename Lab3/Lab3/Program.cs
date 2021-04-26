using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            CarInfo car = new CarInfo();
            string answer = "y";
            do
            {
                Console.WriteLine("Catalog of used Cars");
                Console.WriteLine("1.Adding a New Car");
                Console.WriteLine("2.Modify the Details of a particular car");
                Console.WriteLine("3.Search for a particular car in the Catalog");
                Console.WriteLine("4.List all the cars in the Catalog");
                Console.WriteLine("5.Delete a car from the Catalog");
                Console.WriteLine("6.Quit");
                Console.Write("Enter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        car.Add();
                        break;
                    case 2:
                        CarInfo.Modify();
                        break;
                    case 3:
                        CarInfo.Search();
                        break;
                    case 4:
                        CarInfo.List();
                        break;
                    case 5:
                        CarInfo.Delete();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                }

          

            } while (answer == "y");
            Console.ReadLine();
        }
       
    }
}
