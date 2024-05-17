using System;

namespace Product_OrderTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Electronic electronic  = new Electronic("Huawei P60Pro",1500,"plastic");
            Clothes clothes=new Clothes("EA7",500,50);
            Clothes clothes2=new Clothes("D&G",550,48);
            Order order = new Order();
            order.AddProduct(electronic);
            order.AddProduct(clothes);
            order.AddProduct(clothes2);
            order.AddProduct(clothes2);
            order.AddProduct(clothes2);
            order.RemoveProduct(clothes);
            //order.RemoveProduct(clothes2);
            order.GetProductsDetails();
            Console.WriteLine(order.GetTotalAmount());
        }
    }
}
