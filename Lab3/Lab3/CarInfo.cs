
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class CarInfo
    {
        static int i = 0;
        static Car[] catalog = new Car[10];
        public void Add()
        {
            Console.Write("Enter Cars Make: ");
            string carsmake = Console.ReadLine();
            Console.Write("Enter Cars Model: ");
            string model = Console.ReadLine();
            Console.Write("Enter Cars Year: ");
            string year = Console.ReadLine();
            Console.Write("Enter Cars Sale price ");
            int saleprice = Convert.ToInt32(Console.ReadLine());
            Car car = new Car(carsmake, model, year, saleprice);
            catalog[i] = car;
            i++;
            Console.WriteLine("Car Details added");
        }
        public static void Modify()
        {
            Console.Write("Enter Car Make to moidfy: ");
            string carmakemodify = Console.ReadLine();
            Console.Write("Enter Car Model to modify: ");
            string modelmodify = Console.ReadLine();
            foreach(Car j in catalog)
            
            {
                if (j!=null && j.carsmake == carmakemodify && j.model == modelmodify)
                {
                    Console.Write("Enter New Cars Make: ");
                    string newcarsmake = Console.ReadLine();
                    Console.Write("Enter New Car Model: ");
                    string newmodel = Console.ReadLine();
                    j.carsmake = newcarsmake;
                    j.model = newmodel;

                }

            }
        }
        public static void Search()
        {
            int count = 0;
            Console.Write("Enter Cars Make: ");
            string carsearch = Console.ReadLine();
            for (int j=0;j<catalog.Length-1;j++)
            {
                if (catalog[j] != null && catalog[j].carsmake == carsearch)
                {
                    
                        Console.WriteLine("Your Car Info");
                    Console.WriteLine($"Cars Make:{catalog[j].carsmake}\n Cars Model: {catalog[j].model}\n Year: {catalog[j].year}\n Saleprice:{catalog[j].saleprice}\n ");

                    count = 1;
                  
                }
               
            }
            if (count != 1)
            {
                Console.WriteLine("\n \t Car Not FOund\n");
            }
        }
        public static void Delete()
        {
            int count = 0;
            Console.Write("Enter Cars Make to delete: ");
            string carsdelete = Console.ReadLine();
            Console.Write("Enter Cars Model to delete: ");
            string modeldelete = Console.ReadLine();
            
            for (int j = 0; j <=catalog.Length-1; j++)
            {
                
                    if (catalog[j]!=null && catalog[j].carsmake == carsdelete && catalog[j].model == modeldelete)
                    {
                        catalog[j] = null;
                    count = 1;
                        Console.WriteLine("\nDeleted\n");
                    }
                
            }
            if(count!=1)
            {
                Console.WriteLine("No cars are found to delete:");
            }


        }
        public static void List()
        {
            int count = 0;
            Console.WriteLine("\nList of Cars");
            for (int i = 0; i <= catalog.Length - 1; i++)
            {
                if (catalog[i] != null)
                {
                    Console.WriteLine($"Cars Make:{catalog[i].carsmake}\n Cars Model: {catalog[i].model}\n Year: {catalog[i].year}\n Saleprice:{catalog[i].saleprice}\n ");

                }
                else
                {
                    count = 1;
                }
            }
            if(count==1)
            {
                Console.WriteLine("No cars are added\n");
            }
        }
       
    }
}
