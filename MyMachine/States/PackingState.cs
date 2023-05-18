using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.States
{
    public class PackingState : State
    {
        public void ChooseProduct()
        {
            Console.WriteLine("You cannot change the selection now!");

            throw new NotImplementedException();
        }

        public void ClickToGetBag()
        {
            throw new NotImplementedException();
        }

        public void ClickToPay()
        {
            Console.WriteLine("You already paid!");
            throw new NotImplementedException();
        }

        public void ClickToWrap()
        {
            throw new NotImplementedException();
        }

        public Product GetProduct()
        {
            throw new NotImplementedException();
        }
    }
}
