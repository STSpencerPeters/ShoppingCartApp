using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class ShoppingCart
    {
        private Product[] productList;
        private int itemCount;

        public ShoppingCart(int capacity)
        {
            productList = new Product[capacity];
            itemCount = 0;
        }

        public Product[] Product
        {
            get { return productList; }
        }

        public int ItemCount
        {
            get { return itemCount; }
        }

        public void AddProduct(Product product)
        {
            if(itemCount < productList.Length)
            {
                productList[itemCount] = product;
                itemCount++;
                Console.WriteLine(product.Name + " was added to the cart");
            }
            else
            {
                Console.WriteLine("The shopping cart is full");
            }

        }

        public void RemoveProduct(Product product)
        {
            Boolean found = false;
            for(int i = 0; i < itemCount; i++)
            {
                if (productList[i] == product)
                {
                    productList[i] = null;
                    itemCount--;
                    found = true;
                    Console.WriteLine(product.Name + " was removed from the shopping cart");
                    break;
                }
            }

            if(!found)
            {
                Console.WriteLine("The product does not exist");
            }
        }
    }
}
