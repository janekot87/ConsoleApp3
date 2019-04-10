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

            int action = 0;
            List<Event> events = new List<Event>();
            do
            {
                action = ChooseAction();
                DoAction(action, events);
            } while (action != 0);
        }

        private static void DoAction(int action, List<Event> events)
        {
            switch (action)
            {
                case 1:

                    events.Add(Event.GetEvent());
                    break;
                case 2:

                    PrintArray(events);

                    break;
                case 3:
                    var result1 = events[1].Equals(events[2]);
                    Console.WriteLine(result1);
                    var result2 = events[1].Equals(events[3]);
                    Console.WriteLine(result2);

                    var arrayStreaming = GetStreamingArray(events);

                    break;

                case 0:
                    break;

                default:
                    Console.WriteLine(String.Format("Unknown action: {0}", action));
                    break;
            }
        }

        private static Streaming.Event[] GetStreamingArray(List<Event> events)
        {
            Streaming.Event[] arrayStreaming = new Streaming.Event[events.Count];

            for (int i = 0; i < arrayStreaming.Length; i++)
            {
                arrayStreaming[i] = Mapper.Map(events[i]);
            }

            return arrayStreaming;
        }

        private static void PrintArray(List<Event> events)
        {
            foreach (var api in events)
            {
                Console.WriteLine(api.Id);
                Console.WriteLine(api.Type);
                Console.WriteLine(api.EventName);
                Console.WriteLine(api.TotalBets);
                Console.WriteLine(api.TotalDeposit);
                Console.WriteLine(api.StartEventDate);
                Console.WriteLine(api.IsLive);
                Console.WriteLine(api.LiveGameState.GameTime);
                Console.WriteLine(api.LiveGameState.ClockRunning);
                Console.WriteLine(api.LiveGameState.ClockDirection);
                Console.WriteLine(api.NamePattern.Id);
                Console.WriteLine(api.NamePattern.Pattern);
            }
        }

        private static int ChooseAction()
        {
            var isInputOk = false;
            int action2 = 0;
            while (!isInputOk)
            {
                Console.WriteLine("1 - Add event to list \r\n");
                Console.WriteLine("2 - Print events list \r\n");
                Console.WriteLine("3 - Map events \r\n");
                Console.WriteLine("0 - Exit \r\n");
                try
                {
                    Console.WriteLine("Enter the action number: ");
                    action2 = Int32.Parse(Console.ReadLine());
                    isInputOk = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Entered action is incorrect");
                    Console.ReadLine();
                    Console.Clear();
                }
            }

            return action2;
        }
    }
}