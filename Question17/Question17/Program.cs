using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfString = new List<string>();
            Console.WriteLine("Enter the number od the characters You want to enter ");
            var char_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the characters");
            
            for(int i = 0; i < char_number ; i++)
            {
                var character = Console.ReadLine();
               listOfString.Add(character);
            }


            Console.WriteLine("Enter the character that you want to remove from the list :");
            var remove_char = Console.ReadLine();

            listOfString.Remove(remove_char);

            Console.WriteLine("New List");
            foreach (var Chars in listOfString)
            {
                Console.WriteLine(Chars);
            }
        }
    }
}
