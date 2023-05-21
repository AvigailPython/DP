using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.States
{
     public abstract class State
    {
        public Machine Machine { get; set; }
        abstract public void ChooseProduct();
        abstract public void ClickToPay();
        abstract public void ClickToWrap(Product prduct);
        abstract public Product GetProduct(Product product);

    }
}
