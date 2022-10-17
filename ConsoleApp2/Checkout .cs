using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Checkout
    {   
        Dictionary<string, decimal> listdistinct = new Dictionary<string, decimal>();     //dictionary co cac phan tu la 1 cap gom 2 so key, value
        
        decimal total = 0;
        public void Scan(string item)
        {
            if (listdistinct.ContainsKey(item))
            {
                listdistinct[item]++;
            }
            else
            {
                listdistinct.Add(item, 1);
            }
        }
        public decimal Total(List<Product> product)
        {
            decimal Countmbp = 0;
            decimal disCountIpd = 0;
            foreach (var i in product)
            {
                decimal x = 0;
                foreach (var j in listdistinct)
                {
                    
                    if (i.SKU == j.Key)
                    {

                        if (j.Key == "atv")
                        {

                            x = j.Value - ((j.Value / 3) < 1 ? 0 : (Math.Floor(j.Value / 3)));
                        }
                        else if (j.Key == "mbp")
                        {
                            Countmbp = j.Value;
                            x = j.Value;

                        }
                        else if (j.Key == "ipd")
                        {
                            if (j.Value > 4)
                            {
                                disCountIpd = j.Value * 50;
                            }

                            x = j.Value;
                        }
                        else if (j.Key == "vga")
                        {
                            x = j.Value - Countmbp;
                        }
                        total += i.Price * x - disCountIpd;
                    }
                }               
            }
            return total;
        }
    }
}
