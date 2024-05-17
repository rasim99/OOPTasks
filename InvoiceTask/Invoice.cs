using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceTask
{
    internal class Invoice
    {


        public string Account { get; private set; }
        public string Customer { get; private set; }
        public string Provider { get; private set; }

       public  string Article { get;  set; }
       public  int Quantity { get;  set; }
       public double Price { get;  set; }

        public Invoice( string account,string customer,string provider)
        {
            Account = account;
            Customer = customer;
            Provider = provider;


        }

        public void CostCalculation( bool needEdv)
        {
            if (needEdv)
            {
                Console.WriteLine(Math.Round(Price * Quantity + CaculateEDV(), 2) + " EDV : "+Math.Round(CaculateEDV(),2)+" NeedEdv :"+ needEdv);
                GetDetails();
            }
            else
            {
                Console.WriteLine(Math.Round((Price * Quantity), 2) + " EDV : 0" +" NeedEdv :" + needEdv);
                GetDetails();
            }
            
        }

       public double CaculateEDV()
        {
            return (Price *Quantity)* 0.18;
        }

        public void GetDetails()
        {
            Console.WriteLine($"Customer  :{Customer} " +
                $"  Account : {Account}  Provider  :{Provider}  " +
                $" Article  : {Article}  Quantity  :{Quantity} " +
                $" Price  : {Math.Round( Price,2)} ");
        }
    }
}
