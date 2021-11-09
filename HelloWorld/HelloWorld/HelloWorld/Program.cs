using System;
using System.Collections.Generic;
using System.IO;
using HelloWorld.Data;
using HelloWorld.Model;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            var people = PersonData.LoadPeople();

            Console.WriteLine(people.Count);
            
        }
            //Person p10 = new Person();

            //p10.FirstName = "Petr";
            //p10.LastName = "Suldovský";
            //p10.DateofBirth = new DateTime(1918, 6, 6);
            //int age1 = p10.Age();

            //Person p20 = new Person();

            //p20.FirstName = "Daniela";
            //p20.LastName = "Suldovská";
            //p20.DateofBirth = new DateTime(1968, 6, 26);
            //int age2 = p20.Age();

            //var p = new Person("Jan", "Hakr",new DateTime(1980,1,3));
            //p.HomeAddress.City = "Praha";
            //p.HomeAddress.Street = "Limuzská";

            //var p2 = new Person("Jana", "Nová", new DateTime(1995, 1, 13));
            //p.HomeAddress.City = "Praha";
            //p.HomeAddress.Street = "Kubelíkova";


            //PersonData.SavePerson(p2);

            
            
            //Console.WriteLine(p);
/*
            Person oldest = p1.Age() >= p2.Age() ? p1 : p2;
            Console.WriteLine($"Nejstarší je {oldest.FirstName} {oldest.LastName}");

            Cars Opel = new Cars();
            Opel.Color = "Blue";
            Opel.Kilometers = 2000;

            Invoice inv1 = new Invoice();
            inv1.Customer = "EON";
            inv1.InvoiceItem = "Gas 01-05 2022";
            inv1.Price = 10000;
*/
            
    }

        
    
 }