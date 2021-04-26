using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        struct Box
        {
            public int length;
           public  int width;
            public Box(int l, int w)
            {
                this.length = l;
                this.width = w;

            }
            public void Area()
            {
                Console.WriteLine("Area"+length*width);
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
