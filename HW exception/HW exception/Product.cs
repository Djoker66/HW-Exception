using System;
using System.Collections.Generic;
using System.Text;

namespace HW_exception
{
    internal class Product
    {

        public string Name;
        public double Price;

        public Product(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public string GetInfo()
        {
            return $"Name: {Name} - Price: {Price}";
        }
    }
}
