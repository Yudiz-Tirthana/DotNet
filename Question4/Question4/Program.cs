using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[] { 1, 2, 3, 4, 5, 3, 5, 4, 2, 1, 3, 4, 2, 5, 6, 3, 3, 2, 4, 5, 6, 7, 4, 8, 8, 8, 7, 6, 2, 4, 2, 1, 1, 2 };
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 5, 4, 3, 2, 1, 1, 2, 2 };

            var result = from num in numbers
                         group num by num into y
                         select y;

            foreach(var res in result)
            {
                Console.WriteLine("Number : " + res.Key + " Count " + res.Count() + " of the number");
            }
        }
    }
}
