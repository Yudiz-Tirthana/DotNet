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
            Console.WriteLine("Enter the number to check whether the number is palindrome or not :");
            int number = int.Parse(Console.ReadLine());

            int reminder, sum = 0;
            int temp = number;

            while(number > 0){
                reminder=number%10;
                sum = (sum*10) + reminder;
                number = number/10;
            }
            if(temp == sum){
                Console.WriteLine($"The entered number is Palindrome");
            }
            else{
                Console.WriteLine($"The entered number is not Palindrome");
            }

           
        }
    }
}