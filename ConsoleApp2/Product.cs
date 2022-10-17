using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Product
    {
        public string SKU { set; get; }
        public string Name { set; get; }
        public decimal Price { set; get; }
        public Product(string sku, string name, decimal price)
        {
            SKU = sku; Name = name; Price = price; 
        }

    }
}
