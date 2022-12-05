using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qusetion5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "apple";

            var result = from ch in str
                         group ch by ch into y
                         select y;

            foreach(var res in result)
            {
                Console.WriteLine("Character : " + res.Key + " Appered " + res.Count() + " times in the string");
            }
        }
    }
}
