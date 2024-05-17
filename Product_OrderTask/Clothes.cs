using System;
using System.Collections.Generic;
using System.Text;

namespace Product_OrderTask
{
    internal class Clothes : Product
    {
        public int Size { get; set; }

        public Clothes(string name, int price, int size) : base(name, price)
        {
            Size = size;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"{Name} {Price}  {Size}");
        }
    }
}
