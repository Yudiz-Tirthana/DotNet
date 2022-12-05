using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[] {1,12,32,234,341,54,34,542,2465,356,635,67,25,245,245,256,635,76,875,75,87,78,89,90,900,123};

            var result = from num in Numbers
                         where num > 80
                         select num;

            Console.WriteLine("Numbers greater than 80 are  ");
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
        }
    }
}
