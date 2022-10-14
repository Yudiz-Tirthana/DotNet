using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number for the factorial :");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;

            Console.Write("The factors are ");
            for(int i=1 ; i<= number; i++){
                factorial = factorial*i;
                
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine($"The factorialof the number {number} is {factorial}");
           
        }
    }
}