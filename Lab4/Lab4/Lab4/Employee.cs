using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class Employee
    {

        public int employeeId;
        public string employeeName;
        public string address;
        public string city;
        public string department;
        public double salary;


        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public abstract double GetSalary();
    }
    }
