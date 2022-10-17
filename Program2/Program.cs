using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to get fibonacci :");
            int number = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;

            Console.Write($"{a} {b} ");

            for(int i=1 ; i<= number; i++){
                int c = a + b;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }
        }
    }
}