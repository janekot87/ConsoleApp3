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
            var np1 = new NamePattern(1, "pattern1");
            e1.NamePattern.Id = np1.Id;
            e1.NamePattern.Pattern = np1.Pattern;
            

            var e2 = new Event();
            e2.Id = "1";
            e2.Type = "Fixture";
            e2.EventName = "First";
            e2.TotalBets = 1;
            e2.TotalDeposit = 1;
            e2.StartEventDate = new DateTime(2019, 2, 12);
            e2.IsLive = true;
            var np2 = new NamePattern(1, "pattern1");
            e2.NamePattern.Id = np2.Id;
            e2.NamePattern.Pattern = np2.Pattern;

            var e3 = new Event();
            e3.Id = "1";
            e3.Type = "Fixture";
            e3.EventName = "First";
            e3.TotalBets = 1;
            e3.TotalDeposit = 1;
            e3.StartEventDate = new DateTime(2019, 2, 12);
            e3.IsLive = true;
            var np3 = new NamePattern(3, "pattern3");
            e3.NamePattern.Id = np3.Id;
            e3.NamePattern.Pattern = np3.Pattern;

            var result1 = e1.Equals(e2);
            Console.WriteLine(result1);
            var result2 = e1.Equals(e3);
            Console.WriteLine(result2);

           Api.Event[] array1 = new Api.Event[3];
            array1[0] = e1;
            array1[1] = e2;
            array1[2] = e3;


        }
    }
}
