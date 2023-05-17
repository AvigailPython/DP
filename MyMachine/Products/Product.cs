using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public abstract class Product
    {
        public double Price { get; set; }
        public static int Id { get; set; }
        public Provider Provider { get; set; }
    }
}
