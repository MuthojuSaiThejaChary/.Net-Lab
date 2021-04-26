using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7library
{
    public class EmployeeInfo
    {
        public List<Employee> employees = new List<Employee>();
        //public ProductInfo()
        //{
        //    products = new List<Product>()
        //    {
        //        new Product(){Pid=1,Pname="Mouse",Price=500,Stock=10}
        //    };
        //}
        //Add Product
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public Employee DisplayEmployee( int empno)
        {
            Employee employee = null;
            foreach (Employee p in employees)
            {
                if (p.EmployeeNumber.Equals(empno))
                {
                    employee = p;
                }
            }
            return employee;
        }
        public void Display()
        {
            
                Console.WriteLine("EmployeeNumber EMployeeName Salary PFAttributes");
                foreach (Employee e in employees)
                {
                    Console.WriteLine("{0} \t\t{1}\t {2}\t {3} ", e.EmployeeNumber, e.EmployeeName, e.BasicSalary, e.Pfattributes);

                }
          
            
           
        }
        public bool DeleteEmployee(int employeenumber)
        {
            Employee employee = null;
            foreach (Employee emp in employees)
            {
                if (emp.EmployeeNumber == employeenumber)
                {
                    employee = emp;
                    break;
                }
            }
            if (employee != null)
            {
                employees.Remove(employee);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
