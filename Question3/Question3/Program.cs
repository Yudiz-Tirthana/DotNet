using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12};

            var result = from num in numbers
                         let sqrt = num * num
                         select new { num, sqrt };

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
