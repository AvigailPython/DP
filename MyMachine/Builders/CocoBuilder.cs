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
    public class CocoBuilder : IHotDrinkBuilder
    {
        public Machine Machine { get; set; }
        public Coco CupOfCoco { get; set; }
        public HotDrink GetResult() => CupOfCoco;

        public CocoBuilder()
        {
            CupOfCoco = new Coco();
        }

        public void Mix() => Console.WriteLine("mixing...");
        

        public void PutMilk()
        {
            CupOfCoco.Milk = 1;
            Machine.Stock.AllRawMaterials[eRawMaterials.Milk].RemoveAt(0);
            Console.WriteLine("putting milk");
        }

        
        public void PutPowder()
        {
            CupOfCoco.Powder = 1;
            Machine.Stock.AllRawMaterials[eRawMaterials.CocoPowder].RemoveAt(0);
            Console.WriteLine("putting coco powder");
        }

        public void PutSugar()
        {
            CupOfCoco.Sugar = 1;
            Machine.Stock.AllRawMaterials[eRawMaterials.Sugar].RemoveAt(0);
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
