using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(',');

            Checkout co = new Checkout();
            for (int i = 0; i < arr.Count(); i++)
            {
                var item = arr[i].Trim();
                co.Scan(item);             
            }
            
            var products = new List<Product>()       
            {
                 new Product("ipd", "Super iPad", 549.99),
                 new Product("mbp", "MacBook Pro", 1399.99),
                 new Product("atv", " Apple TV", 109.50),
                 new Product("vga", "VGA adapter", 30.00)

            };
            //co.Total(products);
            Console.WriteLine(co.Total(products));
            
        }
    }
}
