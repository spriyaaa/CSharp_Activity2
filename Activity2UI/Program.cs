using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Activity2BL;

namespace Activity2UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            Console.WriteLine(c1.CustomerId);
            Customer c2 = new Customer();
            Console.WriteLine(c2.CustomerId);

          

            Product pr1 = new Product();
            Console.WriteLine(pr1.ProductId);
            Product pr2 = new Product();
            Console.WriteLine(pr2.ProductId);

           

            Purchase p1 = new Purchase();
            Console.WriteLine(p1.PurchaseId);
            Purchase p2 = new Purchase();
            Console.WriteLine(p2.PurchaseId);

           

            Seller s1 = new Seller();
            Console.WriteLine(s1.SellerId);
            Seller s2 = new Seller();
            Console.WriteLine(s2.SellerId);

  

        }
    }
}
