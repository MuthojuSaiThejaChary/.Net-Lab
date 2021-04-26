using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3Q1Library;

namespace Lab3Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant employee = new Participant();
            ParticipantInfo employeeinfo = new ParticipantInfo();
            Console.Write("Enter EmpID:");
            employee.EmpId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name:");
            employee.Name = Console.ReadLine();
            Console.Write("Enter Foundation Marks:");
            employee.FoundationMarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter DotNet Marks:");
            employee.DotNetMarks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Web Basic Marks:");
            employee.WebBasicMarks = Convert.ToInt32(Console.ReadLine());
            int totalmarks=employeeinfo.TotalMarks(employee);
            employeeinfo.CalculatePercentage(employee);


            Console.WriteLine("EMPLOYEE PERCENTAGE:" +Convert.ToDouble(employeeinfo.GetPercentage(employee)));
            Console.WriteLine("EMPLOYEE TOTAL MARKS:" +totalmarks);

            Console.ReadLine();
        }
    }
}
