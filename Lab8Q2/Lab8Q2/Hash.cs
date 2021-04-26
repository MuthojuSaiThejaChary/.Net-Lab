using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab8Q2
{
    class Hash
    {
         
        Hashtable hashtable = new Hashtable();
        public Hash this[int j]
        {
            get { return (Hash) hashtable[j]; }
            set { hashtable.Add(j,value); }
        }
        public Hashtable GetHashtable()
        {
           //  Create and return new Hashtable.
            //Hashtable hashtable = new Hashtable();
            hashtable.Add("Area", 1000);
            hashtable.Add("Perimeter", 55);
            hashtable.Add("Mortgage", 540);
            return hashtable;
        }
    }
}
