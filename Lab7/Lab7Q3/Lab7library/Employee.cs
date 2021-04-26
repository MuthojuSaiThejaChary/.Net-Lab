using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7library
{
    public class Employee
    {
        private int employeeNumber;
        private string employeeName;
        private double basicSalary;
        private string pfattributes;

        public int EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }
        public string Pfattributes { get => pfattributes; set => pfattributes = value; }
        public Employee()
        {

        }

        public Employee(int employeeNumber, string employeeName, double basicSalary, string pfattributes)
        {
            this.employeeNumber = employeeNumber;
            this.employeeName = employeeName;
            this.basicSalary = basicSalary;
            this.pfattributes = pfattributes;
        }


    }

}
