using DP;
using DP.Products;
using MyMachine.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMachine
{
    public class Stock
    {
        public void InitBamba(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                AllBambas.Add(new Bamba());
            }
        }
        public void InitBisli(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
                AllBislis.Add(new Bisli());
            }
        }
        public void InitDoritos(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
                AllDoritoses.Add(new Doritos());
            }
        }
        public void InitCola(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                AllCola.Add(new Cola());
            }
        }
        public void InitJuice(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
                AllJuices.Add(new Juice());
            }
        }
        public void InitWater(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
                AllWater.Add(new Water());
            }
        }
        public void InitCoffeePowder(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
                AllCoffePowder.Add(new CoffeePowder());
            }
        }
        public void InitBlackCoffeePowder(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
                AllBlackCoffeePowder.Add(new BlackCoffeePowder());
            }
        }
        public void InitCocoPowder(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
                AllCocoPowder.Add(new CocoPowder());
            }
        }
        public void InitMilk(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
                AllMilk.Add(new Milk());
            }
        }
        public void InitSugar(int amount)
        {

            for (int i = 0; i < amount; i++)
            {
                AllSugar.Add(new Sugar());
            }
        }

        public List<Bamba> AllBambas { get; set; }
        public List<Bisli> AllBislis { get; set; }
        public List<Doritos> AllDoritoses { get; set; }
        public List<Cola> AllCola { get; set; }
        public List<Juice> AllJuices { get; set; }
        public List<Water> AllWater { get; set; }
        public List<CoffeePowder> AllCoffePowder { get; set; }
        public List<BlackCoffeePowder> AllBlackCoffeePowder { get; set; }
        public List<CocoPowder> AllCocoPowder { get; set; }
        public List<Milk> AllMilk { get; set; }
        public List<Sugar> AllSugar { get; set; }
        public Dictionary<eProduct, double> Prices { get; set; }
        public Stock()
        {
            AllBambas = new List<Bamba>();
            AllBislis = new List<Bisli>();
            AllDoritoses = new List<Doritos>();
            AllCola = new List<Cola>();
            AllJuices = new List<Juice>();
            AllWater = new List<Water>();
            AllCoffePowder = new List<CoffeePowder>();
            AllBlackCoffeePowder = new List<BlackCoffeePowder>();
            AllCocoPowder = new List<CocoPowder>();
            AllMilk = new List<Milk>();
            AllSugar = new List<Sugar>();
            Prices = new Dictionary<eProduct, double>
            {
                { eProduct.Bamba, Bamba.Price },
                { eProduct.Bisli, Bisli.Price },
                { eProduct.Doritos, Doritos.Price },
                { eProduct.Cola, Cola.Price },
                { eProduct.Juice, Juice.Price },
                { eProduct.Water, Water.Price },
                { eProduct.Coffee, Coffee.Price },
                { eProduct.Coco, Coco.Price },
                { eProduct.Cappucino, Cappucino.Price },
                { eProduct.BlackCoffee, BlackCoffee.Price }

            };
        }
    }
}
