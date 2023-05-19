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
        public Machine(int bambaAmount, int bisliAmount, int doritosAmount)
        {
            Stock = new Stock();
            Stock.InitBamba(bambaAmount);
            Stock.InitBisli(bisliAmount);
            Stock.InitDoritos(doritosAmount);
            SoldProducts = new List<Product>();
            HotDrinkMaker = new HotDrinkMaker();    
        }
        public List<Product> SoldProducts { get; set; }
        public Stock Stock { get; set; }
        public State MachineState { get; set; }
        public Prod ChosenProduct { get; set; }
        public HotDrinkMaker HotDrinkMaker { get; set; }


        public void ChooseProduct() => MachineState.ChooseProduct();
        public void ClickToPay() => MachineState.ClickToPay();
        public void ClickToWrap() => MachineState.ClickToWrap();
        public void ClickToGetBag() => MachineState.ClickToGetBag();
        public Product GetProduct() => MachineState.GetProduct();
        public void ChangeMachineState(State state) { MachineState = state; }
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
            Console.WriteLine("לבמבה הקש 1");
            Console.WriteLine("לבסלי הקש 2");
            Console.WriteLine("לדוריטוס הקש 3");
            Console.WriteLine("לחזרה לתפריט הראשי הקש 0");
            bool valiedInput = Int32.TryParse(Console.ReadLine(), out int input);
            if (valiedInput)
            {
                switch (input)
                {
                    case 0:
                        MainMenu();
                        break;
                    case 1:
                        ChosenProduct = Stock.AllBambas[0];
                        break;
                    case 2:
                        ChosenProduct = Stock.AllBislis[0];
                        break;
                    case 3:
                        ChosenProduct = Stock.AllDoritoses[0];
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
            Console.WriteLine("לקולה הקש 1");
            Console.WriteLine("למיץ הקש 2");
            Console.WriteLine("למים הקש 3");
            Console.WriteLine("לחזרה לתפריט הראשי הקש 0");
            bool valiedInput = Int32.TryParse(Console.ReadLine(), out int input);
            if (valiedInput)
            {
                switch (input)
                {
                    case 0:
                        MainMenu();
                        break;
                    case 1:
                        ChosenProduct = Stock.AllCola[0];
                        break;
                    case 2:
                        ChosenProduct = Stock.AllJuices[0];
                        break;
                    case 3:
                        ChosenProduct = Stock.AllWater[0];
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        ColdDrinkMenu();
                        break;
                }
                Console.WriteLine("Do you want to go to Payment? y/n");
                string ifGoToPay = Console.ReadLine();
                if (ifGoToPay == "y")
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
                        ChosenProduct = eProduct.Cuppucino;
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
            MachineState = new ProductSelectionState(this);
            MachineState.ChooseProduct();
        }
    }
}
