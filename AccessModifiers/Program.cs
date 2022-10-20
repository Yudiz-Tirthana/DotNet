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




        // Creating another class
        // by class is internal(the code is only accessible within its own assembly(Classes are stored in namespaces ane namespaces are stored in assembly) but not from another assembly)

        class Car
        {
            // private string model;
            // private string color;
            // private int price;
            public string model;
            public string color;
            public int price;


            // Method
            public void PrintCarInformation()
            {
                Console.WriteLine($"Model : {model}");
                Console.WriteLine($"Color : {color}");
                Console.WriteLine($"Price : {price}");
                Console.ReadLine();
            }

            //Code For private
            // static void Main(string[] args)
            // {

            //     // Creating an object of other class
            //     Car myCar = new Car();

            //     // Putting the main method in the class car so that we can use the variables of the Car class
            //     myCar.model = "Ferrar";
            //     myCar.color = "Black";
            //     myCar.price = 30000000;

            //     // Calling the method
            //     myCar.PrintCarInformation();

            // }
        }
    }
}
