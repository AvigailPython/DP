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
        public void InitProduct<T>(eProduct P, int amount) where T : Product, new()
        {
            for (int i = 0; i < amount; i++)
            {
                AllProducts[P].Add(new T());
            }
        }
        public void InitProduct<T>(eRawMaterials P, int amount) where T : Product, new()
        {
            for (int i = 0; i < amount; i++)
            {
                AllRawMaterials[P].Add(new T());
            }
        }
        public Dictionary<eProduct, double> Prices { get; set; }
        public Dictionary<eProduct, List<Product>> AllProducts { get; set; }
        public Dictionary<eRawMaterials, List<Product>> AllRawMaterials { get; set; }
        public Stock()
        {
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
            AllProducts = new Dictionary<eProduct, List<Product>> {
                { eProduct.Bamba, new List<Product>()},
                { eProduct.Bisli, new List<Product>()},
                { eProduct.Doritos,new List<Product>() },
                { eProduct.Cola, new List<Product>() },
                { eProduct.Juice, new List<Product>()},
                { eProduct.Water,new List<Product>()},
            };
        }
    }
}
