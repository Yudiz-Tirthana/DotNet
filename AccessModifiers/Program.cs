using System;

namespace Access_Modifiers
{

    class Program
    {

        //     static void Main(string[] args){

        //         // Creating an object of other class
        //         Car myCar = new Car();

        //         // Calling the Method
        //         // myCar.model
        //         // private access modifiers
        //         // The model is not accessible because we have delcared it as private
        //         // We can access that in the same class but not in other class
        //         // By default the access modifiers of the class and method are private.

        // }

        // Creating another class

        class Car
        {
            private string model;
            private string color;
            private int price;


            // Method
            private void PrintCarInformation()
            {
                Console.WriteLine($"Model : {model}");
                Console.WriteLine($"Color : {color}");
                Console.WriteLine($"Price : {price}");
                Console.ReadLine();
            }

            static void Main(string[] args)
            {

                // Creating an object of other class
                Car myCar = new Car();

                // Putting the main method in the class car so that we can use the variables of the Car class
                myCar.model = "Ferrar";
                myCar.color = "Black";
                myCar.price = 30000000;

                // Calling the method
                myCar.PrintCarInformation();

            }
        }
    }
}