using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.States
{
    public interface State
    {
        public Machine Machine { get; set; }
        public void ChooseProduct();
        public void ClickToPay();
        public void ClickToWrap();
        public void ClickToGetBag();
        public Product GetProduct();

    }
}
