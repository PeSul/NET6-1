using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Data
{
    public class PersonData
    {
        // field - staticka polozka
        const string personDataFile = "people.txt";
        //property
        //static string PersonDataFile { get; set; }

        //metoda pro ulozeni - pripojeni jedne osoby na konec souboru
        public static void SavePerson(Person person)
        {
            var line = $"{person.FirstName};{person.LastName};{person.DateofBirth};{person.HomeAddress.City};{person.HomeAddress.Street}";
            line += Environment.NewLine;
            File.AppendAllText(personDataFile, line);
        }

        public static List<Person> LoadPeople(string file = "people.txt") //nepovinný parametr string file = "People.txt"
        {
            var people = new List<Person>();

            var lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                var items = line.Split(';');
                Person p = new Person();
                p.FirstName = items[0];
                p.LastName = items[1];
                p.DateofBirth = DateTime.Parse(items[2]);
                p.HomeAddress.City = items[3];
                p.HomeAddress.Street = items[4];

                people.Add(p);
            }

            return people;
        }

    }




    } 