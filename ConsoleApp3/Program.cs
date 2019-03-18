using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Api;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Event e1;
            e1 = new Event();
            
            e1.Id = "1";
            e1.Type = "Fixture";
            e1.EventName = "First";
            e1.TotalBets = 1;
            e1.TotalDeposit = 1;
            e1.StartEventDate = new DateTime(2019,2,12);
            e1.IsLive = true;
            e1.NamePattern = new NamePattern(1, "one");
            e1.LiveGameState = new LiveGameState();
            e1.LiveGameState.GameTime = 1;
            e1.LiveGameState.ClockRunning = false;
            e1.LiveGameState.ClockDirection = ClockDirection.Timer;

           var e2 = new Event();
            e2.Id = "1";
            e2.Type = "Fixture";
            e2.EventName = "First";
            e2.TotalBets = 1;
            e2.TotalDeposit = 1;
            e2.StartEventDate = new DateTime(2019, 2, 12);
            e2.IsLive = true;
            e2.NamePattern = new NamePattern(1, "one");
            e2.LiveGameState = new LiveGameState();
            e2.LiveGameState.GameTime = 1;
            e2.LiveGameState.ClockRunning = false;
            e2.LiveGameState.ClockDirection = ClockDirection.Timer;

            var e3 = new Event();
            e3.Id = "1";
            e3.Type = "Fixture";
            e3.EventName = "First";
            e3.TotalBets = 1;
            e3.TotalDeposit = 1;
            e3.StartEventDate = new DateTime(2019, 2, 12);
            e3.IsLive = true;
            e3.NamePattern = new NamePattern(1, "one");
            e3.LiveGameState = new LiveGameState();
            e3.LiveGameState.GameTime = 1;
            e3.LiveGameState.ClockRunning = false;
            e3.LiveGameState.ClockDirection = ClockDirection.Stopwatch;

            var result1 = e1.Equals(e2);
            Console.WriteLine(result1);
            var result2 = e1.Equals(e3);
            Console.WriteLine(result2);

           Api.Event[] arrayApi = new Api.Event[3];
            arrayApi[0] = e1;
            arrayApi[1] = e2;
            arrayApi[2] = e3;

          
           
            Streaming.Event[] arrayStreaming = new Streaming.Event[3];
          
            for (int i = 0; i < arrayStreaming.Length; i++)
            {
                arrayStreaming[i] = Mapper.Map(arrayApi[i]);
            }


        }
    }
}
