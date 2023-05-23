using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP
{
    public class Provider
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public void UpdateAmount(int amount, Product p)
        {
            Console.WriteLine($"You have {amount} units from {p.Name}");
        }
    }
}
