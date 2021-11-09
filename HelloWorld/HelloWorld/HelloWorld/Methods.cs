using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class MethodsDay1
    {
        private static void IsAdult()
        {
            // podle data narozeni zjistete
            // jestli je uzivatel plnolety

            Console.WriteLine("Zadej datum oddělené tečkami");
            DateTime datum = DateTime.Parse(Console.ReadLine());

            TimeSpan ts = DateTime.Now - datum;

            if (ts.TotalDays / 365.0 >= 18)
            {
                Console.WriteLine("Jsi dospělý");
            }
            else
            {
                Console.WriteLine("Nejsi dospělý");
            }
        }


        /// <summary>
        /// Convert temperature from F to C and print to console
        /// </summary>
        static string ConvertFtoCandPrint()
        {
            // vytvorte metodu ktera prevadi stupne F na C
            // a prevadejte cisla ze vstupu od uzivatele

            Console.WriteLine("Zadej teplotu ve stupnich F:");

            string user_input = Console.ReadLine();

            try
            {
                double f = double.Parse(user_input);
                double c = ConvertFtoC(f);
                Console.WriteLine($"{f}°F je {c}°C");
            }
            catch (FormatException ex)
            {
                if (user_input != "x")
                    File.AppendAllText("errorlog.txt", ex.Message + Environment.NewLine);
            }
            catch (Exception ex)
            {
                File.AppendAllText("errorlog.txt", "general exception: " + ex.Message + Environment.NewLine);
            }

            return user_input;

        }

        public static void Hello(string name)
        {
            string name5p = name;



            if (name == "Lukáš")
            {
                name5p = "Lukáši";
            }
            else if (name == "Karel")
            {
                name5p = "Karle";
            }
            else if (name == "Petr")
            {
                name5p = "Petře";
            }
            else
            {
                name5p += ", omlouvám se, ale tvoje jméno neumím skloňovat.";
            }
            //string pozdrav;

            string pozdrav = "Ahoj " + name5p;

            Console.WriteLine(pozdrav);
        }

        public static (int, int) Calc(int x)
        {
            // vytvorte metodu ktera vstup vynasoby 2
            // a pricte  10

            int result = x * 2 + 10;

            return (3, 5);
        }



        /// <summary>
        /// converts temperature from F to C
        /// </summary>
        /// <param name="tempF">temperature F as double</param>
        /// <returns>temperature C</returns>
        static double ConvertFtoC(double tempF)
        {
            return (tempF - 32) / 1.8;
        }
    }
}