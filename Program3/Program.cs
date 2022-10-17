using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number for the factorial :");
            int number = int.Parse(Console.ReadLine());

            int count=0;

            for(int i=1 ; i<= number; i++){
                if(number % i == 0){
                    count++;
                }
            }
            if(count == 2){
                Console.WriteLine($"{number} is the prime number");
            }
            else{
                Console.WriteLine($"{number} is not the prime number");
            }
        }
    }
}