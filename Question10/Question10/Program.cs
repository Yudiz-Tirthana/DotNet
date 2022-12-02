using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {   
            List<int> templist = new List<int>();
            Console.WriteLine("Input the number of members on the List ");
            var number =Convert.ToInt32(Console.ReadLine());
            
            for(int i = 0; i<number ; i++ )
            {
                Console.Write("Member {0} : ", i);
                int memlist = Convert.ToInt32(Console.ReadLine());
                templist.Add(memlist);
            }

            Console.WriteLine("Input the value above you want to display the members of the list :");
            int check_number = Convert.ToInt32(Console.ReadLine());

            List<int> FilterList = templist.FindAll(x => x > check_number ? true : false);
            Console.WriteLine("The numbers greater than {0} are : ",check_number);

            foreach(var temp_num in FilterList)
            {
                Console.WriteLine(temp_num);
            }
            Console.ReadLine();
        }
    }
}
