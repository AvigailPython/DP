using DP.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMachine.Stock.Stock
{
    public class WaterStock : ProductStock<Water>
    {
        public WaterStock(int amount) : base(amount)
        {
        }
    }
}
