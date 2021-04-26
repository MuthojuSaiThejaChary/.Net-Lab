using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab7library;

namespace Lab7Q3
{
    class Program
    {
        static int count = 0;
        static void Main()
        { 
            
            EmployeeInfo employeeinfo = new EmployeeInfo();
            do
            {
                Console.WriteLine("1.Add New Employee");
                Console.WriteLine("2.searching Records");
                Console.WriteLine("3.Delete Records");
                Console.WriteLine("4.View All Records");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Enter your Choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Employee c = GetDetails();
                            count++;
                            employeeinfo.AddEmployee(c);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter Employee No");
                            int empno = Convert.ToInt32(Console.ReadLine());
                            Employee employee = employeeinfo.DisplayEmployee(empno);
                            if (employee != null)
                            {
                                Console.WriteLine("Employee No: " + employee.EmployeeNumber);
                                Console.WriteLine("Employee Name: " + employee.EmployeeName);
                                Console.WriteLine("Basic Salary: " + employee.BasicSalary);
                                Console.WriteLine("PF Attributes: " + employee.Pfattributes);

                            }
                            else
                                Console.WriteLine("Contact Not Exist");
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Enter Employee Number to Delete:");
                            int employeenumber = int.Parse(Console.ReadLine());
                            
                            if (employeeinfo.DeleteEmployee(employeenumber))
                            {
                                count--;
                                Console.WriteLine("Employee Record Deleted.");
                            }
                            else
                                Console.WriteLine("Invalid Employee Details");

                        }
                        break;
                    case 4:
                        if (count != 0)
                        {
                            employeeinfo.Display();
                        }else
                        {
                            Console.WriteLine("No Employees Found. Press 1 to Add Employee data or 5 to exit");
                        }
                          break;
                    case 5:
                        Environment.Exit(0);
                        break;


                }

            } while (true);
        }

        private static Employee GetDetails()
        {
            Employee employee = new Employee();
            Console.WriteLine("Enter Employee Details");
            Console.WriteLine("Enter Employee No");
            employee.EmployeeNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            employee.EmployeeName = Console.ReadLine();
            Console.WriteLine("Enter Basic Salary");
            employee.BasicSalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter PF attributes:");
            employee.Pfattributes = Console.ReadLine();

            return employee;

        }
    }
}