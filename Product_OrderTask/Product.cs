using System;
using System.Collections.Generic;
using System.Text;

namespace Product_OrderTask
{
    internal abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product( string name , int price)
        {
             Name = name;
            Price = price;
        }
        public abstract void GetDetails();
    }
}
