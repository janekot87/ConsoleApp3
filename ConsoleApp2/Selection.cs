using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Selection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public bool IsDisabled { get; set; }
        public string Status { get; set; }


        public static Selection GetSelection()
        {
            var sel = new Selection();


            Console.WriteLine("Enter Selection Id: ");
            sel.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Selection Name: ");
            sel.Name = Console.ReadLine();
            Console.WriteLine("Enter Selection Title: ");
            sel.Title = Console.ReadLine();
            Console.WriteLine("Enter Selection IsDisabled true or false: ");
            sel.IsDisabled = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Selection Status: ");
            sel.Status = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();
            return sel;

        }
    }

}
