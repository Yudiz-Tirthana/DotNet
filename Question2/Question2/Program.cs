using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 5,6,8,10,12,15,9,13,19,23};

            var result = from n in numbers
                         where n % 2 == 0
                         select n;

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
