using System;
using System.IO;
using HelloWorld.Model;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.FirstName = "Petr";
            p1.LastName = "Suldovský";
            p1.DateofBirth = new DateTime(1918, 6, 6);
            int age1 = p1.Age();

            Person p2 = new Person();

            p2.FirstName = "Daniela";
            p2.LastName = "Suldovská";
            p2.DateofBirth = new DateTime(1968, 6, 26);
            int age2 = p2.Age();

            Person oldest = p1.Age() >= p2.Age() ? p1 : p2;
            Console.WriteLine($"Nejstarší je {oldest.FirstName} {oldest.LastName}");

            Cars Opel = new Cars();
            Opel.Color = "Blue";
            Opel.Kilometers = 2000;

            Invoice inv1 = new Invoice();
            inv1.Customer = "EON";
            inv1.InvoiceItem = "Gas 01-05 2022";
            inv1.Price = 10000;
            
    }

        
    
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
//string firstname = items[0];
//string lastname = items[1];

//Console.WriteLine($"Jméno: {firstname} Příjmení: {lastname}");



//string input = "";

//while (input != "x")
//{
//    input = ConvertFtoCandPrint();
//}

//{

//    Console.WriteLine("Zadej datum narození ve formatu RRRR.MM.DD");
//    DateTime datum = DateTime.Parse(Console.ReadLine());

//    TimeSpan age = DateTime.Now - datum;

//    if (age.TotalDays / 365 >= 18)
//    {
//        Console.WriteLine("adult");
//    }
//    else
//    {
//        Console.WriteLine("child");
//    }
//    DateTime date = new DateTime(2021, 11, 08, 16, 0, 0);

//    DateTime now = DateTime.Now;
//    var twoweeks = date.AddDays(14);

//    Console.WriteLine(date.ToShortDateString());
//}

//string input = "";

//while (input != "x")
//{
//    Console.WriteLine("Zadej jméno a příjmení / x pro konec");
//    input = Console.ReadLine();

//    if (input == "x")
//        return;

//    Console.WriteLine("Zadej věk / x pro konec");
//    string age = Console.ReadLine();

//    string name_trimmed = input.Trim();
//    //string[] items = name_trimmed.Split(" ");

//    File.AppendAllText("lide.txt", $"{name_trimmed};{age}{Environment.NewLine}");

//}
