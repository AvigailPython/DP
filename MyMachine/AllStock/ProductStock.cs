using DP;
using MyMachine.AllStock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMachine.Stock.Stock
{
    public class ProductStock<T> : IProductStock<T> where T : Product, new()
    {
        public  List<T> Products { get; set; }
        public  List<Provider> Providers { get; set; }
        public  int MinAmount { get; set; }

        public ProductStock(int amount)
        {
            Providers = new List<Provider>();
            Products = new List<T>();
            for (int i = 0; i < amount; i++)
            {
                Products.Add(new T());
            }

        }
        public void AddProvider(Provider p)
        {
            Providers.Add(p);
        }
        public void RemoveProvider(Provider p)
        {
            Providers.Remove(Providers.Find(x => x.Id == p.Id));
        }
        public void NotifyProviders()
        {
            Providers.ForEach(p => p.UpdateAmount(this.Products.Count()));
        }
    }
}
