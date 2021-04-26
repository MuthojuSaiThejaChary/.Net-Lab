using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Q2
{
    class DataEntryException:ApplicationException
    {
        public  DataEntryException(string msg):base(msg)
        {

        }
        public override string Message => base.Message;
    }
}
