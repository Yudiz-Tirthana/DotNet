using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Cities = new string[] { "rome", "london", "nairobi", "california", "zurich", "new Delhi", "amsterdam", "abu dhabi", "paris" };

            var result = from city in Cities
                         where city.StartsWith("a")
                         where city.EndsWith("m")
                         select city;

            foreach(var res in result)
            {
                Console.WriteLine("Cities are : " + res);
            }
        }
    }
}
