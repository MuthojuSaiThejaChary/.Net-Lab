using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab8Q2
{
   class Program
        {
        static void Main()
            {
            Hash hash = new Hash();
            Hashtable hs =hash.GetHashtable();
           bool task1= hs.Contains("Perimeter");
            if(task1)
            {
                Console.WriteLine("Found Perimeter");
            }
           
            Console.WriteLine("Index of Area is" + hs["Area"]);
            hs.Remove("Mortgage");
            foreach(DictionaryEntry h in hs)
            {

                Console.WriteLine($"{h.Key} {h.Value}");
            }
            Console.ReadLine();
            }
           
        }
        
  
}
