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
        public Coco CupOfCoco { get; set; }
        public HotDrink GetResult() => CupOfCoco;


        public void Mix() => Console.WriteLine("mixing...");
        

        public void PutMilk()
        {   CupOfCoco.Milk = 100;
            Console.WriteLine("putting 100ml of milk");
        }

        
        public void PutPowder()
        {
            CupOfCoco.Powder = 15;
            Console.WriteLine("putting 15g of coco powder");
        }

        public void PutSugar()
        {
            CupOfCoco.Sugar = 20;
            Console.WriteLine("putting 20g of sugar");
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
