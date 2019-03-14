using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Market
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SportId { get; set; }
        public int LeagueId { get; set; }
        public int Capasity;

        public List<Selection> Selections;

        
        public Market()
        {
        }



        public Market(int c)
        {
            Capasity = c;
            Selections = new List<Selection>();
        }


        public void AddSelection(Selection value)
        {
            if (Selections.Count < Capasity)
            {
               Selections.Add(value);
            }
            else
            {
                Console.WriteLine("you have reached the selection capacity");
            }


        }
    }



}
