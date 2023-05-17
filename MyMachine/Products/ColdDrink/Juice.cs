using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Products
{
    public class Juice : ColdDrink
    {
        public static int Qty { get; set; }
        public Juice()
        {
            Qty--;
        }
    }
}
