using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What you want to check in Palindrom :");
            Console.WriteLine("1. String");
            Console.WriteLine("2. Integer");
            var number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            { 
                case 1:
                    Console.WriteLine("Enter the String to check whether the string is palindrom or not :");
                    string String = Console.ReadLine();
                    var Reverse_String = String.Reverse();
                    bool result = String.SequenceEqual(Reverse_String);
                    if(result == true)
                    {
                        Console.WriteLine("The entered string is Palindrom");
                    }
                    else
                    {
                        Console.WriteLine("The entered string is not Palindrom");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the interger's String to check wheter the string is palindrom or not");
                    int integer = Convert.ToInt32(Console.ReadLine());
                    var integer1 = integer.ToString();
                    var Reverse_Interger = integer1.Reverse();
                    bool result1 = integer1.SequenceEqual(Reverse_Interger);
                    if (result1 == true)
                    {
                        Console.WriteLine("The entered Integer String is Palindrom");
                    }
                    else
                    {
                        Console.WriteLine("The entered Integer String is not Palindrom");
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Enter the valid input.");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
