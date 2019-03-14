using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main()
        {
            


                var sel1 = Selection.GetSelection();
                var sel2 = Selection.GetSelection();
                var sel3 = Selection.GetSelection();
               

            var mrk1 = new Market(2)
            {
                Id = 1,
                Name = "Market1",
                SportId = 1,
                LeagueId = 1
            };
                mrk1.AddSelection(value: sel1);
                mrk1.AddSelection(value: sel2);
                mrk1.AddSelection(value: sel3);
              

            foreach (var i in mrk1.Selections)
            {
                Console.WriteLine(value: i.Id);
                Console.WriteLine(value: i.Name);
                Console.WriteLine(value: i.Title);
                Console.WriteLine(value: i.IsDisabled);
                Console.WriteLine(i.Status);
                Console.WriteLine();
            }












            















        }

        

        }


    }
    

