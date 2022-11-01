using System;
// Create a stack
using System.Collections;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class DSA
    {
        static void Main(string[] args)
        {
            // create a stack
            // using stack class
            Stack my_stack = new Stack();

            // Adding elements in the stack 
            // using Push method
            my_stack.Push("My");
            my_stack.Push("Name");
            my_stack.Push("is");
            my_stack.Push("Tirthana");
            my_stack.Push(null);
            my_stack.Push("Phone Number :");
            my_stack.Push(1234554321);
            my_stack.Push(1953);

            // Accessing the elements of my_stack Stack
            // using foreach loop
            foreach(var elements in my_stack){
                Console.WriteLine(elements);
            }

            Console.WriteLine("Total elements present in " + "my_stack : {0}", my_stack.Count);

            my_stack.Pop();

            //After pop method
            Console.WriteLine("Total elements present in " + "my_stack : {0}", my_stack.Count);

            // //Remove all the elements from the stack
            // my_stack.Clear();

            // //After Clear method
            // Console.WriteLine("Total elements present in " + "my_stack : {0}", my_stack.Count);

            //Obtain the topmost element of my_stack using pop method
            Console.WriteLine("Total elements present in " + "my_stack : {0}", my_stack.Pop());

            Console.WriteLine("Total elements present in " + "my_stack : {0}", my_stack.Count);

            //obtain the topmost element of my_stack using peek method
            Console.WriteLine("Total elements present in " + "my_stack : {0}", my_stack.Peek());

            Console.WriteLine("Total elements present in " + "my_stack : {0}", my_stack.Count);

            //Checking if the element is present in the stack or not
            if(my_stack.Contains("Tirthana") == true){
                Console.WriteLine("Element is found.....!!");
            }
            else{
                Console.WriteLine("Ooopss!! Element not found ..!!");
            }
        }
    }
}