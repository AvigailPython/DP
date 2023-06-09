﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.Builders;
using DP.Products;
using DP.States;
using MyMachine;
using MyMachine.AllStock;
using MyMachine.Builders;
using MyMachine.Stock;

namespace DP
{
    public class Machine
    {
        public Machine()
        {
            Stock = new Stock();
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
        public void ChangeMachineState(State state) { MachineState = state;}
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
                        return;
                    case 2:
                        ColdDrinkMenu();
                        return;
                    case 3:
                        HotDrinkMenu();
                        return;  
                    default:
                        MainMenu();
                        return;
                        
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
                        return;
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
                        return;
                }
                Console.WriteLine("Do you want to go to Payment? y/n");
                string ifGoToPay =  Console.ReadLine();
                if (ifGoToPay == "y")
                    MachineState.ClickToPay();
                else
                {
                    SnacksMenu();
                    return;
                }
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
                        return;
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
                        return;
                }
                Console.WriteLine("Do you want to go to Payment? y/n");
                string ifGoToPay = Console.ReadLine();
                if (ifGoToPay.Equals("y"))
                    MachineState.ClickToPay();
                else
                {
                    ColdDrinkMenu();
                    return ;
                }
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
                        return;
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
                        return;
                }
                Console.WriteLine("Do you want to go to Payment? y/n");
                string ifGoToPay = Console.ReadLine();
                if (ifGoToPay == "y")
                    MachineState.ClickToPay();
                else
                {
                    HotDrinkMenu();
                    return;
                }
            }
            else
            {
                HotDrinkMenu();
                return;
            }
        }
            
        public void TurnOn()
        {
            ChangeMachineState(new ProductSelectionState(this));
            MachineState.ChooseProduct();
        }
    }
}
