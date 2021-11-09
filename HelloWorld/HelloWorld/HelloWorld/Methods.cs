using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorld
{
    class Methods
    {
        //private static void FindOldest()
        //{
        //    int age_max = 0;
        //    string name_oldest = "";

        //    foreach (var line in File.ReadLines("lide.txt"))
        //    {
        //        string[] items = line.Split(';');

        //        string name = items[0];
        //        string age_s = items[1];
        //        int age = int.Parse(age_s);

        //        if (age > age_max)
        //        {
        //            age_max = age;
        //            name_oldest = name;
        //        }
        //    }
        //    Console.WriteLine($"Nejstarší člověk je {name_oldest} ({age_max})");
        //}

        //static int ageSolver(DateTime dateofbirth)
        //{
        //    DateTime today = DateTime.Today;

        //    return (int)((today - dateofbirth).TotalDays / 365);
        //}

        //static int Compare(int x, int y)
        //{
        //    return (x > y ? x : y);
        //}

        ///// <summary>
        ///// metoda konverze teploty
        ///// </summary>
        //static string ConvertFtoCandPrint()
        //{
        //    Console.WriteLine("Zadej teplotu ve stupních Farenheita / x pro konec");

        //    string usr_input = Console.ReadLine();

        //    if (usr_input == "x")
        //        return usr_input;
        //    try
        //    {
        //        double f = double.Parse(usr_input);
        //        double c = ConvertFtoC(f);

        //        Console.WriteLine($"{f} °F je + {c} °C");
        //    }

        //    catch (FormatException ex)
        //    {
        //        if (usr_input != "x")
        //            File.AppendAllText("errorlog.txt", ex.Message + Environment.NewLine);
        //    }
        //    catch (Exception ex)
        //    {
        //        File.AppendAllText("errorlog.txt", "general exception: " + ex.Message + Environment.NewLine);
        //    }

        //    return usr_input;
        //}

        //private static void FindOldest()
        //{
        //    int age_max = 0;
        //    string name_oldest = "";

        //    foreach (var line in File.ReadLines("lide.txt"))
        //    {
        //        string[] items = line.Split(';');

        //        string name = items[0];
        //        string age_s = items[1];
        //        int age = int.Parse(age_s);

        //        if (age > age_max)
        //        {
        //            age_max = age;
        //            name_oldest = name;
        //        }
        //    }
        //    Console.WriteLine($"Nejstarší člověk je {name_oldest} ({age_max})");
        //}

        //static int ageSolver(DateTime dateofbirth)
        //{
        //    DateTime today = DateTime.Today;

        //    return (int)((today - dateofbirth).TotalDays / 365);
        //}

        //static int Compare(int x, int y)
        //{
        //    return (x > y ? x : y);
        //}




        ///// <summary>
        ///// metoda konverze teploty
        ///// </summary>
        //static string ConvertFtoCandPrint()
        //{
        //    Console.WriteLine("Zadej teplotu ve stupních Farenheita / x pro konec");

        //    string usr_input = Console.ReadLine();

        //    if (usr_input == "x")
        //        return usr_input;
        //    try
        //    {
        //        double f = double.Parse(usr_input);
        //        double c = ConvertFtoC(f);

        //        Console.WriteLine($"{f} °F je + {c} °C");
        //    }

        //    catch (FormatException ex)
        //    {
        //        if (usr_input != "x")
        //            File.AppendAllText("errorlog.txt", ex.Message + Environment.NewLine);
        //    }
        //    catch (Exception ex)
        //    {
        //        File.AppendAllText("errorlog.txt", "general exception: " + ex.Message + Environment.NewLine);
        //    }

        //    return usr_input;
        //}

        //static double ConvertFtoC(double tempF)
        //{
        //    return (tempF - 32) * 1.8;
        //}

        //static double ConvertCtoF(double tempC)
        //{
        //    return (tempC / 1.8) - 32;
        //}
        //static void Hello(string name)
        //{
        //    int x = 5;
        //    int y = Calc(x);

        //    Console.WriteLine("Vysledek je:" + y);
        //    Console.WriteLine("x:" + x);
        //}

        //static int Calc(int x)
        //{
        //    //vytvorte metodu ktera pricte vstup vynasobeny 2
        //    // a pricte 10
        //    int result = x * 2 + 10;

        //    x = 55;
        //    Console.WriteLine("x:" + x);
        //    return result;
        //}

    }
}
