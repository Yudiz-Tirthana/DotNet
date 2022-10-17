using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program6
    {
        static void Main(string[] args)
        {
            string Str, revStr = "";
            Console.WriteLine("Enter the string to check whether it is a palindrome :");
            Str = Console.ReadLine();

            for(int i=Str.Length-1; i >= 0; i--){
                revStr += Str[i];
            }
            if(Str == revStr){
                Console.WriteLine($"The entered String {Str} is Palindrom");
            }
            else
            {
                Console.WriteLine($"The entered String {Str} is not Palindrom");
            }
        }
    }
}