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
            int n, r, sum=0, temp;
            Console.WriteLine("Enter the number: ");
            n = int.Parse(Console.ReadLine());

            temp = n;

            while(n>0){
                r = n%10;
                sum = sum +(r*r*r);
                n = n/10;
            }
            if(temp == sum){
                Console.WriteLine("The given number is Armstrong number.");
            }
            else{
                Console.WriteLine("The given number is not Armstrong number.");
            }
        }
    }
}