using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab12
{
    class Program
    {
        public static void Read(string file_path)
        {
            try
            {
                
                if(File.Exists(file_path))
                {
                   string s= File.ReadAllText(file_path);
                    Console.WriteLine(s);
                }
                else
                {
                    Console.WriteLine("File Not Exists");
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void Main()
        {
            Console.Write("Enter the path of the file along with filename:");
            string filepath = Console.ReadLine();
            Read(filepath);
            Console.ReadLine();

        }
    }
}
