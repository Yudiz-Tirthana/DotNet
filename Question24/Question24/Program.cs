using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question24
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIrst List
            List<string> listofalphabets = new List<string>();
            Console.WriteLine("Enter the number of the alphabets you want to put int the list : ");
            var List1_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  alphabets :");

            for (int i = 0; i < List1_number; i++)
            {
                string alphabets_value = Console.ReadLine();
                listofalphabets.Add(alphabets_value);
            }

            //Second List
            List<string> listofVegetables = new List<string>();
            Console.WriteLine("Enter the number of the Vegetables you want to put int the list : ");
            var List2_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  Name of the Vegetables :");

            for (int i = 0; i < List2_number; i++)
            {
                var Vegetables_value = Console.ReadLine();
                listofVegetables.Add(Vegetables_value);
            }

            //Third List
            List<int> listofNumber = new List<int>();
            Console.WriteLine("Enter the number of the Numbers you want to put int the list : ");
            var List3_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  Numbers :");

            for (int i = 0; i < List3_number; i++)
            {
                var numbers_value = Convert.ToInt32(Console.ReadLine());
                listofNumber.Add(numbers_value);
            }
            
            //Cross Join
            var result = from alphabets in listofalphabets
                         from vegetables in listofVegetables
                         from numbers in listofNumber
                         select new
                         {
                             alphabets,
                             vegetables,
                             numbers
                         };

            //Display Result
            foreach (var value in result)
            {
                Console.WriteLine("List Of Alphabets {0} , List of vegetable {1}, List of Numbers {2} ", value.alphabets, value.vegetables, value.numbers);
            }
        }
    }
}
