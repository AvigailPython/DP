using DP.Products;
using MyMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Builders
{
    public interface IHotDrinkBuilder
    {
        public Machine Machine { get; set; }
        public void Reset();
        public void PutPowder();
        public void PutSugar();
        public void PutWater();
        public void PutMilk();
        public void Mix();
        public HotDrink GetResult();

    }
}
