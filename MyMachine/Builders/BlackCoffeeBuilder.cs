using DP.Products;
using MyMachine;
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
        public BlackCoffee CupOfBlackCoffee { get; set; }
        public Machine Machine { get ; set ; }

        public HotDrink GetResult() => CupOfBlackCoffee;
        public BlackCoffeeBuilder()
        {
            CupOfBlackCoffee = new HotDrink();
        }

        public void Mix() => Console.WriteLine("mixing...");


        public void PutMilk()
        {
            CupOfBlackCoffee.Milk = 1;
            Machine.Stock.AllRawMaterials[eRawMaterials.Milk].RemoveAt(0);
            Console.WriteLine("putting milk");
        }

        public void PutPowder()
        {
            CupOfBlackCoffee.Powder = 1;
            Machine.Stock.AllRawMaterials[eRawMaterials.BlckCoffeePowder].RemoveAt(0);
            Console.WriteLine("putting coco powder");
        }

        public void PutSugar()
        {
            CupOfBlackCoffee.Sugar = 1;
            Machine.Stock.AllRawMaterials[eRawMaterials.Sugar].RemoveAt(0);
            Console.WriteLine("putting sugar");
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
