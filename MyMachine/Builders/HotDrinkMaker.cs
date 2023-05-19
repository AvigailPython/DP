using DP.Builders;
using MyMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMachine.Builders
{
    public class HotDrinkMaker
    {

        public HotDrink MakeHotDrink(IHotDrinkBuilder builder)
        {
            builder.PutPowder();
            builder.PutSugar();
            builder.PutWater();
            builder.Mix();
            builder.PutMilk();
            builder.Mix();
            return builder.GetResult();
        }

        public HotDrink MakeCappuccino(IHotDrinkBuilder builder)
        {
            builder.PutMilk();
            builder.PutWater();
            builder.PutPowder();
            builder.PutSugar();
            builder.Mix();
            return builder.GetResult();
        }

    }
}