using DP;
using DP.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMachine
{
    public enum eProduct
    {
        Bamba,
        Bisli,
        Doritos
    }
    public class Stock
    {
        public void InitBamba(int amount)
        {
            AmountDict[eProduct.Bamba] = amount;

            for (int i = 0; i < amount; i++)
            {
                AllProducts.Add(new Bamba());
            }
        }
        public void InitBisli(int amount)
        {
            AmountDict[eProduct.Bisli] = amount;

            for (int i = 0; i < amount; i++)
            {
                AllProducts.Add(new Bisli());
            }
        }
        public void InitDoritos(int amount)
        {
            AmountDict[eProduct.Doritos] = amount;

            for (int i = 0; i < amount; i++)
            {
                AllProducts.Add(new Doritos());
            }
        }
        public List<Product> AllProducts { get; set; }
        public Dictionary<eProduct, double> AmountDict { get; set; }
        public Stock()
        {
            AllProducts = new List<Product>();
            AmountDict = new Dictionary<eProduct, double>();
        }
    }
}
