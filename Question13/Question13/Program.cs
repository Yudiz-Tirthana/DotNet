using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1;
            int n, i;

            Console.WriteLine("Convert a string array to a string");
            Console.WriteLine("Input number of Stirngs to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine());
            arr1 = new String[n];
            Console.Write("Input {0} strings for the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Element[{0}] :", i);
                arr1[i] = Console.ReadLine();
            }

            string newstring = String.Join(", ", arr1.Select(s => s.ToString()).ToArray());
            Console.Write("Here is the string below created with elements of the above array :");
            Console.WriteLine(newstring);
            Console.ReadLine();
        }
    }
}
