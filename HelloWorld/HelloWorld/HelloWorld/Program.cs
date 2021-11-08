using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak se jmenuješ");
                        
            string name = Console.ReadLine();
            string pozdrav = "Ahoj " + name;
            Console.WriteLine(pozdrav);
        }
    }
}
