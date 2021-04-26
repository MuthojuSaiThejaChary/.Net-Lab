using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6Q2
{
    class ProductMock
    {
        private int productID;
        private string productName;
        private double price;
        public ProductMock()
        {

        }
        public ProductMock(int productID, string productName, double price)
        {
            this.ProductID = productID;
            this.ProductName = productName;
            this.Price = price;
        }

        public int ProductID
        {
            get { return productID; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new DataEntryException($"Product ID must be greater than {value}");

                    }
                    productID = value;
                }
                catch (DataEntryException e)
                {
                    Console.WriteLine(e.Message);

                }
            }

        }
        
        public string ProductName
        {
            
            get { return productName; }
            set
            {
                try
                {
                    if (value == "")
                    {
                        throw new DataEntryException("Product Name should not be blank");
                    }
                    if (value.All(char.IsLetterOrDigit))
                    {
                        productName = value;
                    }
                    else
                    {
                        throw new DataEntryException("Prodcut Name should have alphabets and Numbers only");
                    }
                }
                catch (DataEntryException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
        public double Price
        {
            get { return price; }
            set
            {
                try
                {
                    if (value <= 0)
                    {

                        throw new DataEntryException("Price of the Product must be greater than zero");

                    }
                    price = value;
                }
                catch (DataEntryException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
