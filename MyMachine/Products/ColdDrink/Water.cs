using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Products
{
    public class Water : ColdDrink
    {
        public static int Qty { get; set; }
        public Water()
        {
            Qty--;
        }
    }
}
