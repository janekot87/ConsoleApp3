using System;

namespace ConsoleApp3.Api
{
    class Event : IEquatable<Event>
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
            if (this.Id != e.Id) return false;
            if (this.Type != e.Type) return false;
            if (this.EventName != e.EventName) return false;
            if (this.TotalBets != e.TotalBets) return false;
            if (this.TotalDeposit != e.TotalDeposit) return false;
            if (this.StartEventDate != e.StartEventDate) return false;
            if (this.IsLive != e.IsLive) return false;

            return true;
            //return this.Id == e.Id &&
            //       this.Type == e.Type &&
            //       this.EventName == e.EventName &&
            //       this.TotalBets == e.TotalBets &&
            //       this.TotalDeposit == e.TotalDeposit &&
            //       this.StartEventDate == e.StartEventDate &&
            //       this.IsLive == e.IsLive &&
            //       this.LiveGameState.ClockRunning == e.LiveGameState.ClockRunning
            //    ;
        }
    }
}
