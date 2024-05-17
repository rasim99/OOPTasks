using System;
using System.Collections.Generic;
using System.Text;

namespace Product_OrderTask
{
    internal class Electronic : Product
    {
        public string Material { get; set; }

        public Electronic(string name, int price, string material) : base(name, price)
        {
            Material = material;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"{Name} {Price}  {Material}");
        }
    }
}
