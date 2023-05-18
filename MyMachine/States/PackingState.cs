using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.States
{
    public class PackingState : State
    {
        public Machine Machine { get ; set ; }
        public PackingState(Machine machine)
        {
            Machine = machine;  
        }

        public void ChooseProduct()
        {
            Console.WriteLine("אי אפשר לשנות בחירה לאחר התשלום");

            throw new NotImplementedException();
        }

        public void ClickToGetBag()
        {
            throw new NotImplementedException();
        }

        public void ClickToPay()
        {
            Console.WriteLine("התשלום כבר בוצע!");
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
