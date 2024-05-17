using System;

namespace InvoiceTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice("678904", "Alex", "Foxtrot");
            inv.Article = "USB-hab";
            inv.Quantity = 6;
            inv.Price = 30;
            inv.CostCalculation(true);

            Invoice inv2 = new Invoice("678904", "Alex", "Foxtrot");
            inv.Article = "USB-hab";
            inv.Quantity = 7;
            inv.Price = 32.4221;
            inv.CostCalculation(false);
        }
    }
}
