using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.States
{
    public interface State
    {
        public void ChooseProduct();
        public void ClickToPay();
        public void ClickToWrap();
        public void ClickToGetBag();
        public Product GetProduct();

    }
}
