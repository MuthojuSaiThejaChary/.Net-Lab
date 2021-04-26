using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class PermanentEmployee:Employee
    {
        public int noOfLeaves;
        public double providentFund;
        public override double GetSalary()
        {
            return salary - providentFund;
        }
    }
}
