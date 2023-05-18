using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.States;
using MyMachine;

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

        }
        public Stock Stock { get; set; }


        public State MachineState { get; set; }
        public void ChangeMachineState(State state) { MachineState = state; }  
        public void MainMenu() {
            Console.WriteLine("שלום! מה תרצו לקנות? ");
            Console.WriteLine("חטיפים הקש 1");
            Console.WriteLine("שתיה קרה הקש 2");
            Console.WriteLine("שתיה חמה הקש 3");
            bool valiedInput = Int32.TryParse(Console.ReadLine(), out int input);
            if (valiedInput)
            {
                switch (input)
                {
                    case 1:
                        SnacksMenu();
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
                        break ;
                }
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
                }
            }
        }
        public void HotDrinkMenu()
        {
            Console.WriteLine("לקפה הקש 1");
            Console.WriteLine("לשוקו הקש 2");
            Console.WriteLine("לקפה שחור הקש 3");
            Console.WriteLine("לחזרה לתפריט הראשי הקש 0");
            bool valiedInput = Int32.TryParse(Console.ReadLine(), out int input);
            if (valiedInput)
            {
                switch (input)
                {
                    case 0:
                        MainMenu();
                        break;
                }
            }
        }

        public void TurnOn()
        {
            
            MainMenu();
                
        }
    }
}
