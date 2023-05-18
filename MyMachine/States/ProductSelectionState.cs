using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.States
{
    public class ProductSelectionState : State
    {
        public Machine Machine { get; set; }
        public ProductSelectionState(Machine machine)
        {
            Machine = machine;
        }

        public void ChooseProduct() =>  Machine.MainMenu();

        public void ClickToGetBag() => Console.WriteLine("קבלת שקית לאחר התשלום");
    

        public void ClickToPay() => Machine.ChangeMachineState(new PaymentState(Machine));


        public void ClickToWrap() => Console.WriteLine("העטיפה אחרי התשלום");  


        public Product GetProduct()
        {
            Console.WriteLine("המוצר עוד לא מוכן...");
            return null;
        }
    }
}
