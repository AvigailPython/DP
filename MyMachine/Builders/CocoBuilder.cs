using DP.Products;
using MyMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Builders
{
    public class CocoBuilder : IHotDrinkBuilder
    {
        public Machine Machine { get; set; }
        public Coco CupOfCoco { get; set; }
        public HotDrink GetResult() => CupOfCoco;



        public void Mix() => Console.WriteLine("mixing...");
        

        public void PutMilk()
        {
            CupOfCoco.Milk = 1;
            Machine.Stock.AllMilk.RemoveAt(0);
            Console.WriteLine("putting milk");
        }

        
        public void PutPowder()
        {
            CupOfCoco.Powder = 1;
            Machine.Stock.AllCoffePowder.RemoveAt(0);
            Console.WriteLine("putting coco powder");
        }

        public void PutSugar()
        {
            CupOfCoco.Sugar = 1;
            Machine.Stock.AllSugar.RemoveAt(0);
            Console.WriteLine("putting sugar");
        }

        public void PutWater()
        {
            CupOfCoco.Water = 100;
            Console.WriteLine("putting 100ml of water");
        }

        public void Reset()
        {
            CupOfCoco = new Coco();
        }
    }
}
