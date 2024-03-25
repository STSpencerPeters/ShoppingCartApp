using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class ElectronicProducts : Product
    {
        private string brand;
        private string model;

        public ElectronicProducts(string name, double price, Product_Category category, string brand, string model) : base(name,price, category)
        {
            this.brand = brand;
            this.model = model;
        }

        public string Brand
        {
            get { return this.brand; }
        }

        public string Model
        {
            get { return this.model; }
        }

        public override void GetInfo()
        {
            base.GetInfo();
        }
    }
}
