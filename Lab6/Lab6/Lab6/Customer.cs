using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Customer
    {
        private int customerID;
        private string customerName;
        private string address;
        private string city;
        private string phone;
        private double creditLimit;
        public Customer()
        {

        }

        public Customer(int customerID, string customerName, string address, string city, string phone, double CreditLimit)
        {
            this.CustomerID = customerID;
            this.CustomerName = customerName;
            this.Address = address;
            this.City = city;
            this.Phone = phone;
            this.CreditLimit = CreditLimit;
        }

        public int CustomerID { get => customerID; set => customerID = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Phone { get => phone; set => phone = value; }
        public double CreditLimit
        {
            get { return creditLimit; }
            set
            {
                try
                {
                    if (value > 50000)
                        throw new InvalidCreditLimitException("Invalid Credit Limit");
                    else
                        creditLimit = value;

                }
                catch (InvalidCreditLimitException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public class InvalidCreditLimitException : ApplicationException
        {
            public InvalidCreditLimitException(string msg):base(msg)
            { 
            }
            public override string Message => base.Message;
        }

    }
}

