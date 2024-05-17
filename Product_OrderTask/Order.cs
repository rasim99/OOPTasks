using System;
using System.Collections.Generic;
using System.Text;

namespace Product_OrderTask
{
    internal class Order
    {
        Product [] products;
        public int Limit { get;}
        public Product [] Products { get => products; }
        public Order()
        {
            products = new Product[0];
            Limit = 10;
        }
        public void AddProduct(Product product)
        {
            if (Limit>products.Length)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;
            }
            else
            {
                Console.WriteLine("Sifaris limiti kecildi");
            }

        }

        public void RemoveProduct(Product product)
        {
            int index=Array.IndexOf(products, product);
            if (index !=-1)
            {
                for (int i = index; i < products.Length-1; i++)
                {
                    products[i] = products[i+1];
                }
                Array.Resize (ref products, products.Length-1);
            }
            else
            {
                Console.WriteLine("sifarisde bele mehsul yoxdur");
            }
        }
        public void GetProductsDetails()
        {
            foreach (var product in products)
            {
                product.GetDetails();
            }
        }

        

        public double GetTotalAmount()
        {
            double total = 0;
            foreach (var item in products)
            {
                total+= item.Price;
            }
            return total;
        }
    }
}
