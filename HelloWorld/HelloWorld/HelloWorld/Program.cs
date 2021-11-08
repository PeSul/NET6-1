using System;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "";

            while (input != "x")
            {
                input = ConvertFtoCandPrint();
            }

   
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

            double f = double.Parse(usr_input);
            double c = ConvertFtoC(f);
                        
            Console.WriteLine($"{f} °F je + {c} °C");

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
