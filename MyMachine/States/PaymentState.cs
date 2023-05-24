using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Builders;
using MyMachine;
namespace DP.States
{
    public class PaymentState : State
    {

        public override void ChooseProduct() => Machine.ChangeMachineState(new ProductSelectionState());


        public override void ClickToPay()
        {
            Console.WriteLine($"Price: {Machine.Stock.Prices[Machine.ChosenProduct]}");
            Console.WriteLine("Back to the main menu press 0");
            Console.WriteLine("Enter money for pay");
            bool valiedInput = Int32.TryParse(Console.ReadLine(), out int input);
            if (valiedInput)
            {
                if (input == 0)
                {
                    Machine.ChangeMachineState(new ProductSelectionState());
                    Machine.MachineState.ChooseProduct();
                }
                if (input >= Machine.Stock.Prices[Machine.ChosenProduct])
                {
                    Console.WriteLine($"excess:{input -Machine.Stock.Prices[Machine.ChosenProduct]}");
                    //if(Machine.Stock.AllBambas.Count() == )
                    Machine.ChangeMachineState(new PackingState());
                    Machine.MachineState.ClickToWrap(GetSoldProduct());
                }
                else
                {
                    ClickToPay();
                }
            }
        }
            

        public override void ClickToWrap(Product product) => Console.WriteLine("העטיפה אחרי התשלום");

        public override Product GetProduct(Product product)
        {
            Console.WriteLine("המוצר עוד לא מוכן...");
            return null;
        }

        public  Product? GetSoldProduct()
        {
            Product sold = null;

                switch (Machine.ChosenProduct)
                {
                    //case eProduct.Bamba:
                    //    sold = Machine.Stock.AllBambas[0];
                    //    Machine.Stock.AllBambas.RemoveAt(0);
                    //    break;
                    //case eProduct.Bisli:
                    //    sold = Machine.Stock.AllBislis[0];
                    //    Machine.Stock.AllBislis.RemoveAt(0);
                    //    break;
                    //case eProduct.Doritos:
                    //    sold = Machine.Stock.AllDoritoses[0];
                    //    Machine.Stock.AllDoritoses.RemoveAt(0);
                    //    break;
                    //case eProduct.Cola:
                    //    sold = Machine.Stock.AllCola[0];
                    //    Machine.Stock.AllCola.RemoveAt(0);
                    //    break;
                    //case eProduct.Juice:
                    //    sold = Machine.Stock.AllJuices[0];
                    //    Machine.Stock.AllJuices.RemoveAt(0);
                    //    break;
                    //case eProduct.Water:
                    //    sold = Machine.Stock.AllWater[0];
                    //    Machine.Stock.AllWater.RemoveAt(0);
                    //    break;
                    case eProduct.Coffee:
                        sold = Machine.HotDrinkMaker.MakeHotDrink(new CoffeeBuilder());
                        break;
                    case eProduct.BlackCoffee:
                        sold = Machine.HotDrinkMaker.MakeHotDrink(new BlackCoffeeBuilder());
                        break;
                    case eProduct.Cappucino:
                        sold = Machine.HotDrinkMaker.MakeCappuccino(new CoffeeBuilder());
                        break;
                    case eProduct.Coco:
                        Machine.HotDrinkMaker.MakeHotDrink(new CocoBuilder());
                        break;
                    default:
                        sold = Machine.Stock.AllProducts[Machine.ChosenProduct][0];
                        Machine.Stock.AllProducts[Machine.ChosenProduct].RemoveAt(0);
                    break;
                }

           
            return sold;
         }
        
        }
    }

