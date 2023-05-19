using DP.Products;
using MyMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Builders
{
    public class CoffeeBuilder : IHotDrinkBuilder
    {
        public HotDrink CupOfCoffee { get; set; }
        public HotDrink GetResult() => CupOfCoffee;
        public CoffeeBuilder()
        {
            CupOfCoffee = new HotDrink();
        }
        

        public void Mix() => Console.WriteLine("mixing...");


        public void PutMilk()
        {
            CupOfCoffee.Milk = 150;
            Console.WriteLine("putting 150ml of milk");
        }

        public void PutPowder()
        {
            CupOfCoffee.Powder = 20;
            Console.WriteLine("putting 20g of coffee powder");
        }

        public void PutSugar()
        {
            CupOfCoffee.Sugar = 25;
            Console.WriteLine("putting 25g of sugar");
        }

        public void PutWater()
        {
            CupOfCoffee.Water = 50;
            Console.WriteLine("putting 50ml of water");
        }

        public void Reset()
        {
            CupOfCoffee = new Coffee();
        }


    }
}
