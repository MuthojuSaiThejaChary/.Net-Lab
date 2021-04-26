using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Q1Library
{
    public class Participant
    {
        private int empId;
        private string name;
   
        private int foundationMarks;
        private int webBasicMarks;
        private int dotNetMarks;
        public const int totalMarks = 300;
        private int obtainedMarks;
        private double percentage;
        static Participant()
        {
              string companyName = "Corporate University";
        }
        public Participant()
        {

        }

        public Participant(int empId, string name, int foundationMarks, int webBasicMarks, int dotNetMarks, int totalMarks, int obtainedMarks, float percentage)
        {
            this.EmpId = empId;
            this.Name = name;
           
            this.FoundationMarks = foundationMarks;
            this.WebBasicMarks = webBasicMarks;
            this.DotNetMarks = dotNetMarks;
            this.ObtainedMarks = obtainedMarks;
            this.Percentage = percentage;
        }

        public int EmpId { get => empId; set => empId = value; }
        public string Name { get => name; set => name = value; }
        
        public int FoundationMarks { get => foundationMarks; set => foundationMarks = value; }
        public int WebBasicMarks { get => webBasicMarks; set => webBasicMarks = value; }
        public int DotNetMarks { get => dotNetMarks; set => dotNetMarks = value; }
        public int TotalMarks { get => totalMarks;}
        public int ObtainedMarks { get => obtainedMarks; set => obtainedMarks = value; }
        public double Percentage { get => percentage; set => percentage = value; }
    }
}
