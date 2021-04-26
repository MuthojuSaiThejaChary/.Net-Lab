using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Employee
    {
        private int eid;
        private string eName;
        private string joinDate;
        private double salary;

        public int Eid { get => eid; set => eid = value; }
        public string EName { get => eName; set => eName = value; }
        public string JoinDate { get => joinDate; set => joinDate = value; }
        public double Salary { get => salary; set => salary = value; }
    }
}
