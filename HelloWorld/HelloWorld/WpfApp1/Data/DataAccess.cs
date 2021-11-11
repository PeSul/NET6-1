using HelloWorld.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    class DataAccess
    {
        public static ObservableCollection<Person> people = new ObservableCollection<Person>();

        public static void LoadPeopleFromDb()
        {
            using (var db = new PeopleContext())
            {
                var peoplelist = db.People
                    .Include(x => x.HomeAddress)
                    .Include(x => x.Cars)
                    .ToList();

                people = new ObservableCollection<Person>(peoplelist);
            }
        }

        public static void SavePerson(Person personToSave)
        {
            using (var db = new PeopleContext())
            {
                var dbperson = db.People.Find(personToSave.Id);
                dbperson.FirstName = personToSave.FirstName;
                dbperson.LastName = personToSave.LastName;

                db.SaveChanges();
            }

        }

        public static void AddPerson(Person person)
        {
            using (var db = new PeopleContext())
            {
                db.People.Add(person);
                db.SaveChanges();

            }
        }
    }
}
