using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab9
{
    class FileExtensionInfo
    {
        static int count = 0;
        Dictionary<string, string> fileextensiondictionary = new Dictionary<string, string>();
        public string this[string i]
        {
            get { return fileextensiondictionary[i]; }
            set
            {
                fileextensiondictionary[i] = value;
            }
        }
        public void SearchKey(string k)
        {
            try
            {
                Console.WriteLine("key = {0}, value = {1}.", k, fileextensiondictionary[k]);
            }
            catch (Exception e)
            {
                Console.WriteLine("key Not FOund" + e);
            }

        }
    
        public void AddDictionary(string extensionname, string extensiontype)
        {
            fileextensiondictionary.Add(extensionname,extensiontype);
            count++;
        }
        public void ChangeValue(string fileextension)
        {
            if(fileextensiondictionary.ContainsKey(fileextension))
            {
                Console.WriteLine("Enter New File Type:");
                string ftype = Console.ReadLine();
                fileextensiondictionary[fileextension] = ftype;
                Console.WriteLine("Value Updated");

            }
            else
            {
                Console.WriteLine("Enter File Extension is not available");
                Console.WriteLine("Enter Filetype to add");
                string filetype = Console.ReadLine();
                AddDictionary(fileextension, filetype);
            }
        }
        public void DisplayAllRecords()
        {
            if (count != 0)
            {
                Console.WriteLine("FileExtension   FileType");

                foreach (KeyValuePair<string, string> k in fileextensiondictionary)
                {
                    Console.WriteLine(k.Key+"\t\t"+    k.Value);
                   
                }
            }
            else
            {
                Console.WriteLine("Dictionary is Empty");

            }

        }
        public void DeleteRecord(string extension)
        {
            fileextensiondictionary.Remove(extension);
            count--;
            Console.WriteLine("DELETION SUCCESSFUL");
        }
    }
}
