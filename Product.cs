using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Product 
    {
        private string name;
        private double price;
        private Product_Category category;

        public String Name
        {
            get { return name; }
        }

        public double Price
        {
            get { return price; }
        }

        public Product_Category Category
        {
            get { return category; }
        }

        public Product(String n, double p, Product_Category c)
        {
            name = n;
            price = p;
            category = c;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: " + name + "\nPrice: R" + price + "\nCategory: " + category + "\n\n");
        }
    }
}
