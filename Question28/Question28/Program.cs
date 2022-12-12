using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question28
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Rome", "London", "Nairobi", "Califonia", "Zurich", "New Delhi","Amsterdam","Abu Dhabi","Paris" };
            Console.WriteLine("The list of the citeis according to the length and then by the name in ascending order : ");
            IEnumerable<string> cityOrder = cities.OrderBy(str => str.Length).ThenBy(str => str);
            foreach (string city in cityOrder)
                Console.WriteLine(city);
            Console.ReadLine();
        }
    }
}
