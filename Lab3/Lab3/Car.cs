using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Car
    {
        public string carsmake;
        public string model;
        public string year;
        public int saleprice;

        public Car(string carsmake, string model, string year, int saleprice)
        {
            this.carsmake = carsmake;
            this.model = model;
            this.year = year;
            this.saleprice = saleprice;
        }
        
    }
}
