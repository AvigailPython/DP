
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.States
{
    public class ProductSelectionState : State
    {
        //public Machine Machine { get; set; }
        //public ProductSelectionState(Machine machine)
        //{
        //    Machine = machine;
        //}
       

        public override  void ChooseProduct() =>  Machine.MainMenu();
    

        public override void ClickToPay() => Machine.ChangeMachineState(new PaymentState());

        
        public override void ClickToWrap(Product product) => Console.WriteLine("העטיפה אחרי התשלום");  


        public override Product GetProduct(Product product)
        {
            Console.WriteLine("המוצר עוד לא מוכן...");
            return null;
        }
    }
}