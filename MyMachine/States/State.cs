using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.States
{
    public interface State
    {
        public Product ChooseProduct();
        public bool ClickToPay();
        public bool ClickToWrap();
        public bool ClickToGetBag();

    }
}
