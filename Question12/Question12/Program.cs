using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the UpperCase words in a string : ");

            string strNew;

            Console.WriteLine("Input the String");
            strNew = Console.ReadLine();

            var UpperCaseWord = WordFilt(strNew);
            Console.WriteLine("The UPPERCASE words are : ");
            foreach (string strReturn in UpperCaseWord)
            {
                Console.WriteLine(strReturn);
            }
            Console.ReadLine();
        }
        static IEnumerable<string> WordFilt(string mystr)
        {      
            var upWord = mystr.Split(' ').Where(x => String.Equals(x, x.ToUpper(), StringComparison.Ordinal));

            return upWord;
        }
    }
}
