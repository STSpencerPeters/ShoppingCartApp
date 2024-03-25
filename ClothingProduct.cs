using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class ClothingProduct : Product
    {
        private string size;
        private string colour;

        public ClothingProduct(string name, double price, Product_Category category, string s, string c) : base(name,price,category)
        {
            
            size = s;
            colour = c;
        }

        public string Size
        {
            get { return size; }
        }

        public string Colour
        {
            get { return colour; }
        }

        public override void GetInfo()
        {
            base.GetInfo();
        }
    }
}
