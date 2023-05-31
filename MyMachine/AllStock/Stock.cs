using DP;
using DP.Products;
using MyMachine.Products;
using MyMachine.Stock.Stock;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMachine.AllStock;

public class Stock
{
    //public void InitProduct<T>(eProduct P, int amount) where T : Product, new()
    //{
    //    for (int i = 0; i < amount; i++)
    //    {
    //        AllProducts[P].Add(new T());
    //    }
    //}
    //public void InitProduct<T>(eRawMaterials P, int amount) where T : Product, new()
    //{
    //    for (int i = 0; i < amount; i++)
    //    {
    //        AllRawMaterials[P].Add(new T());
    //    }
    //}
    public Dictionary<eProduct, double> Prices { get; set; }
    public Dictionary<eProduct, IProductStock<Product>> AllProducts { get; set; }
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

        AllProducts = new Dictionary<eProduct, IProductStock<Product>> {
            { eProduct.Bamba, new BambaStock(3)},
            { eProduct.Bisli, new BisliStock(12)},
            { eProduct.Doritos,new DoritosStock(15) },
            { eProduct.Cola, new ColaStock(20) },
            { eProduct.Juice, new JuiceStock(30)},
            { eProduct.Water,new WaterStock(20)},
        };

        AllRawMaterials = new Dictionary<eRawMaterials, List<Product>> {
            { eRawMaterials.BlckCoffeePowder, new List<Product>()},
            { eRawMaterials.CocoPowder, new List<Product>()},
            { eRawMaterials.CoffeePowder,new List<Product>() },
            { eRawMaterials.Sugar, new List<Product>() },
            { eRawMaterials.Milk, new List<Product>()},
        };
        
    }
}
