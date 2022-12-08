using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question22
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfString = new List<string>();
            Console.WriteLine("Enter the number of the strings You want to enter ");
            var string_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Strings :");

            for (int i = 0; i < string_number; i++)
            {
                var String_Value = Console.ReadLine();
                listOfString.Add(String_Value);
            }

            Console.WriteLine("Enter the minimum length of item you want to find");
            var min_length = Convert.ToInt32(Console.ReadLine());

            var result = from min_value_string in listOfString
                                         where min_value_string.Length >= min_length
                                         orderby min_value_string
                                         select min_value_string;

            foreach(var new_String in result)
            {
                Console.WriteLine(new_String);
            }
            Console.ReadLine();
        }
    }
}
