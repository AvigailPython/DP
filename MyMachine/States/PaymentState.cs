using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.States
{
    public class PaymentState : State
    {
        public Product ChooseProduct()
        {
            throw new NotImplementedException();
        }

        public bool ClickToGetBag()
        {
            throw new NotImplementedException();
        }

        public bool ClickToPay()
        {
            Console.WriteLine("The packing is after the payment");
            throw new NotImplementedException();
        }

        public bool ClickToWrap()
        {
            throw new NotImplementedException();
        }
    }
}
