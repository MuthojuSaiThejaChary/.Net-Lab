using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            FileExtensionClass cs = new FileExtensionClass();
            FileExtensionInfo fileExtensionInfo = new FileExtensionInfo();
            do
            {
                Console.WriteLine("1.Add Elements into Dictionary");
                Console.WriteLine("2.Change the Value of the Key");
                Console.WriteLine("3.Search Key");
                Console.WriteLine("4.List All the Elements");
                Console.WriteLine("5.Delete Key Value Pair");

                Console.WriteLine("6.Exit");
                Console.WriteLine("Enter your Choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Console.WriteLine("FILE EXTENSIONS");
                            Console.WriteLine("Enter FileExtension");
                            cs.fileextension = Console.ReadLine();
                            Console.WriteLine("Enter File Type");
                            cs.filetype = Console.ReadLine();
                            fileExtensionInfo.AddDictionary(cs.fileextension, cs.filetype);
                        }
                        break;
                    case 2:

                        Console.WriteLine("Enter File Extension Value");
                        string pname = Console.ReadLine();
                        fileExtensionInfo.ChangeValue(pname);

                        break;
                    case 3:
                        {
                            Console.Write("Enter Key:");
                            string k = Console.ReadLine();
                            fileExtensionInfo.SearchKey(k);
                        }
                        break;
                    case 4:
                        {
                            fileExtensionInfo.DisplayAllRecords();
                        }
                        break;
                    case 5:

                        Console.WriteLine("Enter File Extension Key");
                        string fileexten = Console.ReadLine();
                        fileExtensionInfo.DeleteRecord(fileexten);

                        break;
                    case 6:
                        {
                            Environment.Exit(0);
                        }
                        break;


                }
            } while (true);

        }
    }
}


