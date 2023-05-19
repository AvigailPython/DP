using DP;
using DP.Products;
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
        public List<Bamba> AllBambas { get; set; }
        public List<Bisli> AllBislis { get; set; }
        public List<Doritos> AllDoritoses { get; set; }
        public List<Cola> AllCola { get; set; }
        public List<Juice> AllJuices { get; set; }
        public List<Water> AllWater { get; set; }
        public Stock()
        {
            AllBambas = new List<Bamba>();
            AllBislis = new List<Bisli>();
            AllDoritoses = new List<Doritos>();
            AllCola = new List<Cola>();
            AllJuices = new List<Juice>();
            AllWater = new List<Water>();

        }
    }
}
