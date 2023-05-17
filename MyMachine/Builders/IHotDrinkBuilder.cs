using DP.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Builders
{
    public interface IHotDrinkBuilder
    {
        public void Reset();
        public void PutPowder();
        public void PutSugar();
        public void PutWater();
        public void PutMilk();
        public void Mix();
        public CupOfHotDrink GetResult();

    }
}
