using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Products
{
    public class Bamba : Snack
    {
        public static int Qty { get; set; }
        public Bamba()
        {
            Qty--;
        }
    }
}
