using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DP.States;

namespace DP
{
    public class Machine
    {
        public State MachineState { get; set; }
        public void ChangeMachineState(State state) { MachineState = state; }  
        public void TurnOn()
        {
            Console.WriteLine("לחץ 0 לחזרה לתפריט ראשי");
        }
    }
}
