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
            var e1 = new Event();
            e1.Id = "1";
            e1.Type = "Fixture";
            e1.EventName = "First";
            e1.TotalBets = 1;
            e1.TotalDeposit = 1;
            e1.StartEventDate = new DateTime(2019,2,12);
            e1.IsLive = true;
            //e1.NamePattern.Id = 500;
            //e1.NamePattern.Pattern = "pattern1";

            var e2 = new Event();
            e2.Id = "1";
            e2.Type = "Fixture";
            e2.EventName = "First";
            e2.TotalBets = 1;
            e2.TotalDeposit = 1;
            e2.StartEventDate = new DateTime(2019, 2, 12);
            e2.IsLive = true;
            //e2.NamePattern.Id = 500;
            //e2.NamePattern.Pattern = "pattern1";

            var e3 = new Event();
            e3.Id = "1";
            e3.Type = "Fixture";
            e3.EventName = "First";
            e3.TotalBets = 1;
            e3.TotalDeposit = 1;
            e3.StartEventDate = new DateTime(2019, 2, 12);
            e3.IsLive = true;
            //e3.NamePattern.Id = 500;
            //e3.NamePattern.Pattern = "pattern3";

            var result1 = e1.Equals(e2);
            Console.WriteLine(result1);
            var result2 = e1.Equals(e3);
            Console.WriteLine(result2);

            ConsoleApp3.Api.Event[] array1 = new ConsoleApp3.Api.Event[3];

        }
    }
}
