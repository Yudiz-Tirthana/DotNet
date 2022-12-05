using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 5, 4, 3, 2, 1, 1, 2, 2 };

            var result = from num in numbers
                         group num by num into y
                         select y;

            foreach (var res in result)
            {
                Console.WriteLine("Number : " + res.Key + " Frequency " + res.Count() + " Multiplication :" + (res.Key * res.Count()));
            }
        }
    }
}
