using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        {
            Console.WriteLine("");
            throw new NotImplementedException();
        }

        public void ClickToWrap() => Console.WriteLine("העטיפה אחרי התשלום");

        public Product GetProduct()
        {
            Console.WriteLine("המוצר עוד לא מוכן...");
            return null;
        }
    }
}
