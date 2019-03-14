using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public enum ClockDirection
    {
        Stopwatch =2,
        Timer=4
    }
    
    public class LiveGameState
    {
        public bool ClockRunning { get; set; }

        public int? GameTime { get; set; }

       public ClockDirection ClockDirection { get; set; }

       public bool Equal(LiveGameState state)
       {
           if (ClockDirection != state.ClockDirection) return false;
           return true;
       }
    } 
}
