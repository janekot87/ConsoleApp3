using System;

namespace ConsoleApp3.Api
{
    public class Event : IEquatable<Event>
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public string EventName { get; set; }

        public long TotalBets { get; set; }

        public long TotalDeposit { get; set; }

        public DateTime StartEventDate { get; set; }

        public bool IsLive { get; set; }

        public LiveGameState LiveGameState { get; set; }

        public NamePattern NamePattern { get; set; }
        

        

        public bool Equals (Event e)
        {
            if (!this.Id.Equals(e.Id)) return false;
            if (!this.Type.Equals(e.Type)) return false;
            if (!this.EventName.Equals(e.EventName)) return false;
            if (!this.TotalBets.Equals(e.TotalBets)) return false;
            if (!this.TotalDeposit.Equals(e.TotalDeposit)) return false;
            if (!this.StartEventDate.Equals(e.StartEventDate)) return false;
            if (!this.IsLive.Equals(e.IsLive)) return false;
            if (!this.LiveGameState.Equals(e.LiveGameState)) return false;
            if (!this.NamePattern.Equals(e.NamePattern)) return false;
            return true;
        }
        
        public static Event GetEvent()
        {
            var evt = new Event();


            Console.WriteLine("Enter Event Id: ");
            evt.Id = Console.ReadLine();
            Console.WriteLine("Enter Event Type: ");
            evt.Type = Console.ReadLine();
            Console.WriteLine("Enter Event Name: ");
            evt.EventName = Console.ReadLine();
            Console.WriteLine("Enter Event TotalBets: ");
            evt.TotalBets = long.Parse(Console.ReadLine());
            evt.StartEventDate = new DateTime(2019,2,12);
            evt.IsLive = true;
            evt.NamePattern = new NamePattern(1, "one");
            evt.LiveGameState = new LiveGameState();
            evt.LiveGameState.GameTime = 1;
            evt.LiveGameState.ClockRunning = false;
            evt.LiveGameState.ClockDirection = ClockDirection.Timer;
         
            return evt;
            
        }
    }
}
