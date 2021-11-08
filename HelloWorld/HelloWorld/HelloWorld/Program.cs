using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej celé číslo");

            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Výsledek:" + Calc(x));


            //Console.WriteLine("Jak se jmenuješ");

            //string name = Console.ReadLine();

            //string name5p = "name";
            //if (name == "Petr")
            //{
            //    name5p = "Petře ";
            //}
            //else if (name == "Karel")
            //{
            //    name5p = "Karle ";
            //}
            //else
            //{
            //    name5p = name5p + ", pardon Tvé jméno neumín skolňovat";
            //}

        }

        static void Hello(string name)
        {
            int x = 5;
            int y = Calc(x);

            Console.WriteLine("Vysledek je:" + y);
            Console.WriteLine("x:" + x);
        }

        static int Calc(int x)
        {
            //vytvorte metodu ktera pricte vstup vynasobeny 2
            // a pricte 10
            int result = x * 2 + 10;

            x = 55;
            Console.WriteLine("x:" + x);
            return result;
        }
    }

}
