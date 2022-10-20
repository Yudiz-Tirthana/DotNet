/* C# :- Class and Object */

// class name Mobile
class Mobile
{
    // property of class
    int price;
    String storage;
    String color;
    
    // Creating a method and defining it
    public void calling()
    {
        // Defining a method
        Console.WriteLine("Voice Message");
    }

    public void chatting()
    {
        // Defining a method
        Console.WriteLine("Text Message");
    }

    public void Music()
    {
        // Defining a method
        Console.WriteLine("Song.....");
    }
    static void Main(string [] args)
    {

        // Creating an object for propertyand behaviour of class
        Mobile m = new Mobile();
        m.price = 10000;
        m.storage = "8 GB RAM";
        m.color = "Black";

        Console.WriteLine(m.price);
        Console.WriteLine(m.storage);
        Console.WriteLine(m.color);


        m.calling();
        m.chatting();
        m.Music();
    }
}