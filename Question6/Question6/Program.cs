using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Days = new string[]{ "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("Days in a Week :");

            var result = from Day in Days
                         select Day;
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
