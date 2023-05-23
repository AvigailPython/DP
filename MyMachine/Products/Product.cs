using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Provider> Providers { get; set; }
        public Product()
        {
            Providers = new List<Provider>();

        }
        public void AddProvider(Provider p)
        {
            Providers.Add(p);
        }
        public void RemoveProvider(Provider p)
        {
            Providers.Remove(Providers.Find(x => x.Id == p.Id));
        }
        public void NotifyProviders(int amount)
        {
            Providers.ForEach(p => p.UpdateAmount(amount,this));
        }
    }
}
