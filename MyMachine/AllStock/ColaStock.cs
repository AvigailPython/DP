using DP.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMachine.Stock.Stock
{
    public class ColaStock : ProductStock<Cola>
    {
        public ColaStock(int amount) : base(amount)
        {
        }
    }
}
