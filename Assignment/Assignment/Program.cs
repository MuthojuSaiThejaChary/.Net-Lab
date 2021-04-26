using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
           
            Console.WriteLine("Enter No of EMployees:");
            int noOfEmployees = Convert.ToInt32(Console.ReadLine());
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i <= noOfEmployees-1; i++)
            {
                Employee employee = new Employee();
                Console.Write("Enter Eid:");
                employee.Eid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter EName:");
                employee.EName =Console.ReadLine();
                Console.Write("Enter Join Date:");
                employee.JoinDate = Console.ReadLine();
                Console.Write("Enter Salary:");
                employee.Salary = Convert.ToDouble(Console.ReadLine());
                arrayList.Add(employee);
            }
            Console.WriteLine("Enter EMployee id to Search:");
            int employeeid = Convert.ToInt32(Console.ReadLine());
            foreach (Employee employee in arrayList)
            {
                if (employee.Eid == employeeid)
                {
                    Console.WriteLine($"ID:{employee.Eid},Name:{employee.EName},Join Date:{employee.JoinDate},Salary:{employee.Salary}");
                }
            }

            foreach (Employee employee in arrayList)
            {
                Console.WriteLine($"ID:{employee.Eid},Name:{employee.EName},Join Date:{employee.JoinDate},Salary:{employee.Salary}");
            }
            Console.ReadLine();
        }
    }
}
