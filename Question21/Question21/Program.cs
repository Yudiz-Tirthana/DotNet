using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfString = new List<string>();
            Console.WriteLine("Enter the number od the characters You want to enter ");
            var char_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the characters");

            for (int i = 0; i < char_number; i++)
            {
                var character = Console.ReadLine();
                listOfString.Add(character);
            }

            Console.WriteLine("Enter the index that you want to start removing the characters from the list :");
            var remove_char_StartIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the End index :");
            var remove_char_EndIndex = Convert.ToInt32(Console.ReadLine());

            listOfString.RemoveRange(remove_char_StartIndex,remove_char_EndIndex);

            Console.WriteLine("New List");
            foreach (var Chars in listOfString)
            {
                Console.WriteLine(Chars);
            }
        }
    }
}
