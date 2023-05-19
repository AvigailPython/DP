using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyMachine;
namespace DP.States
{
    public class PaymentState : State
    {
        public Machine Machine { get; set; }
        public PaymentState(Machine machine)
        {
            Machine  = machine;
        }

        public void ChooseProduct() => Machine.ChangeMachineState(new ProductSelectionState(Machine));

        public void ClickToGetBag() => Console.WriteLine("קבלת שקית לאחר התשלום");

        public void ClickToPay()
        {   double
            switch (Machine.ChosenProduct)
            {
                case eProduct.Bamba
            }
            Console.WriteLine($"Price: {Machine.ChosenProduct.Price}");
        }

        public void ClickToWrap() => Console.WriteLine("העטיפה אחרי התשלום");

        public Product GetProduct()
        {
            Console.WriteLine("המוצר עוד לא מוכן...");
            return null;
        }
    }
}
