using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.States
{
    public class PackingState : State
    {
        //public Machine Machine { get ; set ; }
        //public PackingState(Machine machine)
        //{
        //    Machine = machine;  
        //}

        public override void ChooseProduct()
        {
            Console.WriteLine("אי אפשר לשנות בחירה לאחר התשלום");

            throw new NotImplementedException();
        }

       

        public override void ClickToPay()
        {
            Console.WriteLine("התשלום כבר בוצע!");
            throw new NotImplementedException();
        }

        public override void ClickToWrap(Product product)
        {
            Console.WriteLine("Do you want to wrap your product? y/n");
            string ifToWrap = Console.ReadLine();
            if (ifToWrap == "y")
                Console.WriteLine("Wrapping......");
            Console.WriteLine("Do you want to get Bag for your product? y/n");
            string ifToGetBag = Console.ReadLine();
            if (ifToGetBag == "y")
                Console.WriteLine("Get Bag......");
            GetProduct(product);
        }

        public override Product GetProduct(Product product)
        {
            Console.WriteLine("Thank tou for for shopping with us");
            return product;
        }
    }
}
