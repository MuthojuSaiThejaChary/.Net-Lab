using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab8Q1Library;

namespace Lab8Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            RTODistrictInfo rtodistrictinfo = new RTODistrictInfo();

            do
            {
                Console.WriteLine("RTO Districts Application");
                Console.WriteLine("1.Add Record in Hashtable");
                Console.WriteLine("2.Search Record");
                Console.WriteLine("3.Display All Records");
                Console.WriteLine("4.Total Count");
                Console.WriteLine("5.Remove any particular Record");
                Console.Write("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter DIstrictNumber");
                        string districtno = Console.ReadLine();
                        Console.WriteLine("Enter District Name");
                        string district = Console.ReadLine();
                        rtodistrictinfo.AddRecord(districtno, district);
                        break;
                    case 2:
                        Console.WriteLine("Enter DIstrictNumber");
                        string d = Console.ReadLine();
                        rtodistrictinfo.SearchRecord(d);

                        break;
                    case 3:
                        rtodistrictinfo.DisplayAllRecords();
                        break;
                    case 4:
                        int noOfRecords = rtodistrictinfo.DisplayCount();
                        Console.WriteLine("Total Records:" + noOfRecords);
                        break;
                    case 5:
                        Console.WriteLine("enter DistrictNO");
                        string districtn= Console.ReadLine();
                        rtodistrictinfo.DeleteRecord( districtn);
                        break;
                    case 6:
                        
                        break;
                }

            }
            while (true);
        }
      
    }
}
