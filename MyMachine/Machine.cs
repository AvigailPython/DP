using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Builders;
using DP.States;
using MyMachine;
using MyMachine.Builders;

namespace DP
{
    public class Machine
    {
        public Machine(int bambaAmount, int bisliAmount, int doritosAmount, int colaAmount, int juiceAmount, int waterAmount, int coffeePowderAmount, int blackCoffeePowderAmount,
            int cocoPowderAmount, int sugarAmount, int milkAmount)
        {
            Stock = new Stock();
            Stock.InitBamba(bambaAmount);
            Stock.InitBisli(bisliAmount);
            Stock.InitDoritos(doritosAmount);
            Stock.InitCola(colaAmount);
            Stock.InitJuice(juiceAmount);
            Stock.InitWater(waterAmount);
            Stock.InitCoffeePowder(coffeePowderAmount);
            Stock.InitBlackCoffeePowder(blackCoffeePowderAmount);
            Stock.InitCocoPowder(cocoPowderAmount);
            Stock.InitSugar(sugarAmount);
            Stock.InitMilk(milkAmount);
            SoldProducts = new List<Product>();
            HotDrinkMaker = new HotDrinkMaker();    
        }
        public List<Product> SoldProducts { get; set; }
        public Stock Stock { get; set; }
        public State MachineState { get; set; }
        public eProduct ChosenProduct { get; set; }
        public HotDrinkMaker HotDrinkMaker { get; set; }


        public void ChooseProduct() => MachineState.ChooseProduct();
        public void ClickToPay() => MachineState.ClickToPay();
        public void ClickToWrap(Product product) => MachineState.ClickToWrap(product);
        public Product GetProduct(Product product) => MachineState.GetProduct(product);
        public void ChangeMachineState(State state) { MachineState = state; MachineState.Machine = this; }
        public void MainMenu()
        {
            Console.WriteLine("Hi! What would you like to buy?");
            Console.WriteLine("Snacks press 1");
            Console.WriteLine("Cold drink press 2");
            Console.WriteLine("Hot drink press 3");
            bool valiedInput = Int32.TryParse(Console.ReadLine(), out int input);
            if (valiedInput)
            {
                switch (input)
                {
                    case 1:
                        SnacksMenu();
                        break;
                    case 2:
                        ColdDrinkMenu();
                        break;
                    case 3:
                        HotDrinkMenu();
                        break;  
                    default:
                        MainMenu();
                        break;
                }
            }

        }
        public void SnacksMenu()
        {
            Console.WriteLine("for bamba press 1");
            Console.WriteLine("for bisli press 2");
            Console.WriteLine("for doritos press 3");
            Console.WriteLine("Back to the main menu press 0");
            bool valiedInput = Int32.TryParse(Console.ReadLine(), out int input);
            if (valiedInput)
            {
                switch (input)
                {
                    case 0:
                        MainMenu();
                        break;
                    case 1:
                        ChosenProduct = eProduct.Bamba;
                        break;
                    case 2:
                        ChosenProduct = eProduct.Bisli;
                        break;
                    case 3:
                        ChosenProduct = eProduct.Doritos;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        SnacksMenu(); 
                        break;
                }
                Console.WriteLine("Do you want to go to Payment? y/n");
                string ifGoToPay =  Console.ReadLine();
                if (ifGoToPay == "y")
                    MachineState.ClickToPay();
                else
                    SnacksMenu();
            }


        }
        public void ColdDrinkMenu()
        {
            Console.WriteLine("for cola press 1");
            Console.WriteLine("for juice 2");
            Console.WriteLine("for water press 3");
            Console.WriteLine("Back to the main menu press 0");
            bool valiedInput = Int32.TryParse(Console.ReadLine(), out int input);
            if (valiedInput)
            {
                switch (input)
                {
                    case 0:
                        MainMenu();
                        break;
                    case 1:
                        ChosenProduct = eProduct.Cola;
                        break;
                    case 2:
                        ChosenProduct = eProduct.Juice;
                        break;
                    case 3:
                        ChosenProduct = eProduct.Water;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        ColdDrinkMenu();
                        break;
                }
                Console.WriteLine("Do you want to go to Payment? y/n");
                string ifGoToPay = Console.ReadLine();
                if (ifGoToPay.Equals("y"))
                    MachineState.ClickToPay();
                else
                    ColdDrinkMenu();
            }
        }
        public void HotDrinkMenu()
        {
            Console.WriteLine("Coffee press 1");
            Console.WriteLine("Cuppucino press 2");
            Console.WriteLine("Coco press 3");
            Console.WriteLine("Black Coffe press 4");
            Console.WriteLine("Back to the main menu press 0");
            bool valiedInput = Int32.TryParse(Console.ReadLine(), out int input);
            if (valiedInput)
            {
                switch (input)
                {
                    case 0:
                        MainMenu();
                        break;
                    case 1:
                        ChosenProduct = eProduct.Coffee;
                        break;
                    case 2:
                        ChosenProduct = eProduct.Cappucino;
                        break;
                    case 3:
                        ChosenProduct = eProduct.Coco;
                        break;
                    case 4:
                        ChosenProduct = eProduct.BlackCoffee;
                        break;
                    default:
                        HotDrinkMenu();
                        break;
                }
                Console.WriteLine("Do you want to go to Payment? y/n");
                string ifGoToPay = Console.ReadLine();
                if (ifGoToPay == "y")
                    MachineState.ClickToPay();
                else
                    HotDrinkMenu();
            }
            else
                HotDrinkMenu();
        }
            
        public void TurnOn()
        {
            ChangeMachineState(new ProductSelectionState());
            MachineState.ChooseProduct();
        }
    }
}
