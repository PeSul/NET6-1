using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Zadej datum narození ve formatu RRRR.MM.DD");
                DateTime datum = DateTime.Parse(Console.ReadLine());

                TimeSpan age = DateTime.Now - datum;

                if (age.TotalDays / 365 >= 18)
                {
                    Console.WriteLine("adult");
                }
                else
                {
                    Console.WriteLine("child");
                }
                DateTime date = new DateTime(2021, 11, 08, 16, 0, 0);

                DateTime now = DateTime.Now;
                var twoweeks = date.AddDays(14);

                Console.WriteLine(date.ToShortDateString());
            }
            
            string input = "";
            
            while(input != "x")
            {
                Console.WriteLine("Zadej jméno a příjmení / x pro konec");
                input = Console.ReadLine();

                Console.WriteLine("Zadej věk / x pro konec");
                string age = Console.ReadLine();

                if (input == "x")
                    return;

                string name_trimmed = input.Trim();
                //string[] items = name_trimmed.Split(" ");

                File.AppendAllText("lide.txt", $"{name_trimmed};{age}{Environment.NewLine}");

            }  
           

           

            

            //string firstname = items[0];
            //string lastname = items[1];

            //Console.WriteLine($"Jméno: {firstname} Příjmení: {lastname}");



            //string input = "";

            //while (input != "x")
            //{
            //    input = ConvertFtoCandPrint();
            //}

   
        }


        /// <summary>
        /// metoda konverze teploty
        /// </summary>
        static string ConvertFtoCandPrint()
        {
            Console.WriteLine("Zadej teplotu ve stupních Farenheita / x pro konec");

            string usr_input = Console.ReadLine();

            if (usr_input == "x")
                return usr_input;
            try
            {
                double f = double.Parse(usr_input);
                double c = ConvertFtoC(f);

                Console.WriteLine($"{f} °F je + {c} °C");
            }

            catch (FormatException ex)
            {
                if (usr_input != "x")
                    File.AppendAllText("errorlog.txt", ex.Message + Environment.NewLine);
            }
            catch (Exception ex)
            {
                File.AppendAllText("errorlog.txt", "general exception: " + ex.Message + Environment.NewLine);
            }

            return usr_input;
        }

        static double ConvertFtoC(double tempF)
        {
            return (tempF - 32) * 1.8;
        }

        static double ConvertCtoF(double tempC)
        {
            return (tempC / 1.8) - 32;
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
    /*private static void NameSklon()
          {
              console.writeline("zadej celé číslo");

              int x = int.parse(console.readline());

              console.writeline("výsledek:" + calc(x));


              console.writeline("jak se jmenuješ");

              string name = console.readline();

              string name5p = "name";
              if (name == "petr")
              {
                  name5p = "petře ";
              }
              else if (name == "karel")
              {
                  name5p = "karle ";
              }
              else
              {
                  name5p = name5p + ", pardon tvé jméno neumín skolňovat";
              }
          }
          */
}
