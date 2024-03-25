namespace ShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClothingProduct shirt = new ClothingProduct("T-Shirt", 20.99, Product_Category.Clothing, "Large", "Red");
            ElectronicProducts laptop = new ElectronicProducts("Laptop", 999.99, Product_Category.Electronics, "Dell", "XPS 15");


            ShoppingCart cart = new ShoppingCart(2);

            cart.AddProduct(shirt);
            cart.AddProduct(laptop);

            foreach(var product in cart.Product)
            {
                if(product != null)
                {
                    product.GetInfo();
                }
            }

            cart.RemoveProduct(laptop);


        }
    }
}
