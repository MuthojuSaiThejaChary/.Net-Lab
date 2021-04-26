using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static int choice = 0;
        static void Main(string[] args)
        {
           

            Console.WriteLine("1.Enter Permanent Employee Data");
            Console.WriteLine("2.Enter Contract Employee Data");
            Console.Write("Enter Your Choice:");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    PermanentEmployee permanentEmployeeobj = new PermanentEmployee();
                    permanentEmployeeobj = new PermanentEmployee();
                    GetEmployeeDetails(permanentEmployeeobj);

                    DisplayEmployee(permanentEmployeeobj);

                    Console.ReadLine();
                    break;
                case 2:
                    ContractEmployee contractemployeeobj = new ContractEmployee();
                    contractemployeeobj = new ContractEmployee();
                    GetEmployeeDetails(contractemployeeobj);

                   

                    DisplayEmployee(contractemployeeobj);

                    Console.ReadLine();
                    break;
            }
            

        }
        static void GetEmployeeDetails(Employee s)
        {
            Console.Write("Enter Employee ID:");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Address:");
            string address = Console.ReadLine();
            Console.Write("Enter City:");
            string city = Console.ReadLine();
            Console.Write("Enter Department:");
            string department = Console.ReadLine();
            Console.Write("Enter Salary:");
            double salary = Convert.ToDouble(Console.ReadLine());
            s.employeeId = sid;
            s.employeeName = name;
            s.city = city;
            s.address = address;
            s.department = department;
            s.Salary = salary;
            if (choice == 1)
            {
                PermanentEmployee pe = (PermanentEmployee)s;
                Console.Write("Enter Provident Fund:");
                double pf = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter No of Leaves:");
                int noofleaves = Convert.ToInt32(Console.ReadLine());
                pe.providentFund = pf;
                pe.noOfLeaves = noofleaves;
            }
            else if (choice == 2)
            {
                ContractEmployee ce = (ContractEmployee)s;
                Console.Write("Enter Perks:");
                double perks = Convert.ToDouble(Console.ReadLine());
                ce.Perks = perks;

            }
        }
        static void DisplayEmployee(Employee s)
        {
            Console.WriteLine("Employee Name \t Salary");

            Console.Write(s.employeeName + "\t\t");
            Console.Write(s.GetSalary());
            Console.WriteLine();

        }

        //static int choice = 0;
        //static void Main(string[] args)
        //{
        //    Employee s = new Employee();

        //    Console.WriteLine("1.Enter Permanent Employee Data");
        //    Console.WriteLine("2.Enter Contract Employee Data");
        //    Console.Write("Enter Your Choice:");
        //    choice = Convert.ToInt32(Console.ReadLine());
        //    switch (choice)
        //    {
        //        case 1:
        //            s = new PermanentEmployee();
        //            break;
        //        case 2:
        //            s = new ContractEmployee();
        //            break;
        //    }
        //    GetEmployeeDetails(s);

        //    DisplayEmployee(s);

        //    Console.ReadLine();

        //}
        //static void GetEmployeeDetails(Employee s)
        //{
        //    Console.Write("Enter Employee ID:");
        //    int sid = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter Employee Name:");
        //    string name = Console.ReadLine();
        //    Console.Write("Enter Address:");
        //    string address = Console.ReadLine();
        //    Console.Write("Enter City:");
        //    string city = Console.ReadLine();
        //    Console.Write("Enter Department:");
        //    string department = Console.ReadLine();
        //    Console.Write("Enter Salary:");
        //    double salary = Convert.ToDouble(Console.ReadLine());
        //    s.employeeId = sid;
        //    s.employeeName = name;
        //    s.city = city;
        //    s.address = address;
        //    s.department = department;
        //    s.Salary = salary;
        //    if (choice == 1)
        //    {
        //        PermanentEmployee pe = (PermanentEmployee)s;
        //        Console.Write("Enter Provident Fund:");
        //        double pf = Convert.ToDouble(Console.ReadLine());

        //        Console.Write("Enter No of Leaves:");
        //        int noofleaves = Convert.ToInt32(Console.ReadLine());
        //        pe.providentFund = pf;
        //        pe.noOfLeaves = noofleaves;
        //    }
        //    else if (choice == 2)
        //    {
        //        ContractEmployee ce = (ContractEmployee)s;
        //        Console.Write("Enter Perks:");
        //        double perks = Convert.ToDouble(Console.ReadLine());
        //        ce.Perks = perks;

        //    }
        //}
        //static void DisplayEmployee(Employee s)
        //{
        //    Console.WriteLine("Employee Name \t Salary");

        //    Console.Write(s.employeeName + "\t\t");
        //    Console.Write(s.GetSalary());
        //    Console.WriteLine();

        //}

    }
}
