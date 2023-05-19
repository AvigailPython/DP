using DP.Products;
using MyMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Builders
{
    public class BlackCoffeeBuilder : IHotDrinkBuilder
    {
        public HotDrink CupOfBlackCoffee { get; set; }
        public HotDrink GetResult() => CupOfBlackCoffee;

        public void Mix() => Console.WriteLine("mixing...");


        public void PutMilk()
        {
            CupOfBlackCoffee.Milk = 20;
            Console.WriteLine("putting 20ml of milk");
        }

        public void PutPowder()
        {
            CupOfBlackCoffee.Powder = 15;
            Console.WriteLine("putting 15g of black coffee powder");
        }

        public void PutSugar()
        {
            CupOfBlackCoffee.Sugar = 30;
            Console.WriteLine("putting 30g of sugar");
        }

        public void PutWater()
        {
            CupOfBlackCoffee.Water = 180;
            Console.WriteLine("putting 180ml of water");
        }

        public void Reset()
        {
            CupOfBlackCoffee = new BlackCoffee();
        }
    }
}
