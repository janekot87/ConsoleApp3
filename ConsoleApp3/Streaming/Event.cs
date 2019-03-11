using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Streaming
{
    public class Event
    {
        public string Id { get; set; }

        public string Type { get; set; }

        public string EventName { get; set; }

        public long TotalBets { get; set; }

        public long TotalDeposit { get; set; }

        public DateTime StartEventDate { get; set; }

        public bool IsLive { get; set; }

       public NamePattern NamePattern { get; set; }
    }
}
