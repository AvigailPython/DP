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
        public Machine Machine { get; set ; }

        public HotDrink GetResult() => CupOfCoffee;
        public CoffeeBuilder()
        {
            CupOfCoffee = new HotDrink();
        }
        

        public void Mix() => Console.WriteLine("mixing...");


        public void PutMilk()
        {
            CupOfCoffee.Milk = 1;
            Machine.Stock.AllMilk.RemoveAt(0);
            Console.WriteLine("putting milk");
        }

        public void PutPowder()
        {
            CupOfCoffee.Powder = 1;
            Machine.Stock.AllCoffePowder.RemoveAt(0);
            Console.WriteLine("putting coffee powder");
        }

        public void PutSugar()
        {
            CupOfCoffee.Sugar = 1;
            Machine.Stock.AllSugar.RemoveAt(0);
            Console.WriteLine("putting sugar");
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
