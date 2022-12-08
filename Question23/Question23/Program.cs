using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question23
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIrst List
            List<string> listofFruits = new List<string>();
            Console.WriteLine("Enter the number of the Fruits you want to put int the list : ");
            var List1_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  Name of the Fruits :");

            for (int i = 0; i < List1_number; i++)
            {
                var Fruit_value = Console.ReadLine();
                listofFruits.Add(Fruit_value);
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
            //Console.WriteLine(listofFruits);
            //Console.WriteLine(listofVegetables);


            //Cross Join
            var result = from fruit in listofFruits
                         from vegetables in listofVegetables
                         select new
                         {
                             fruit,
                             vegetables
                         };

            //Display Result
            foreach (var value in result)
            {
                Console.WriteLine("List Of Fruit {0} , List of vegetable {1} ", value.fruit,value.vegetables);
            }

            //var cartesianProduct = from letterList in charset1
            //                       from numberList in numset1
            //                       select new { letterList, numberList };

            //Console.Write("The cartesian product are : \n");
            //foreach (var productItem in cartesianProduct)
            //{
            //    Console.WriteLine(productItem);
            //}
            Console.ReadLine(); 
        }
    }
}
