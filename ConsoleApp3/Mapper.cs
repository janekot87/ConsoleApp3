using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Api;

namespace ConsoleApp3
{
   public static class Mapper
    {
        public static Streaming.Event Map (Api.Event e)
        {
            var evtStr = new Streaming.Event();
            evtStr.Id = e.Id;
            evtStr.Type = e.Type;
            evtStr.EventName = e.EventName;
            evtStr.TotalBets = e.TotalBets;
            evtStr.TotalDeposit = e.TotalDeposit;
            evtStr.StartEventDate = e.StartEventDate;
            evtStr.NamePattern = e.NamePattern;
            return evtStr;
        }
    }
}
