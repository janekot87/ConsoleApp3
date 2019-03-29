using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            var evt1 = Event.GetEvent();
            var evt2 = Event.GetEvent();
            var evt3 = Event.GetEvent();

            

            List<Event> allEvents = new List<Event>();
                allEvents.Add(evt1);
                allEvents.Add(evt2);
                allEvents.Add(evt3);

       

           var evtlive = allEvents
               .Where(r => r.IsLive)
               .ToList();
           
            Console.WriteLine("Live Events list");
            foreach (var x in evtlive)
              {

                Console.WriteLine(x.Id);
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Order);
                Console.WriteLine(x.StartDate);
                Console.WriteLine(x.IsLive);
                Console.WriteLine(); 


              }

        
            var evtNames = allEvents.Select(e => e.Name).ToList();

            Console.WriteLine("Event names list");

            foreach (var a in evtNames)
            {
               Console.WriteLine(a);

            }
            Console.WriteLine();

      
           var evtFuture = allEvents
               .Where(a => a.StartDate > DateTime.Now)
               .ToList();

            Console.WriteLine("Pre-match Events list");
            foreach (var x in evtFuture)
            {

                Console.WriteLine(x.Id);
                Console.WriteLine(x.Name);
                Console.WriteLine(x.Order);
                Console.WriteLine(x.StartDate);
                Console.WriteLine(x.IsLive);
                Console.WriteLine();
                }


               












            















        }
       
        }
    }

