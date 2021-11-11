using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    public class Person
    {
        public Person()
        {
            HomeAddress = new Address();
        }
        public Person(string firstname, string lastname)
        {
            HomeAddress = new Address();
            FirstName = firstname;
            LastName = lastname;
        }
        public Person(string firstname, string lastname, DateTime dob)
        {
            HomeAddress = new Address();
            FirstName = firstname;
            LastName = lastname;
            DateofBirth = dob;
        }

        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public Address HomeAddress { get; set; } // = new Address(); - vzdy se inicializuje

        public List<Cars> Cars{ get; set; } = new List<Cars>();

        public DateTime DateofBirth { get; set; }

        public int Age()
        {
            return (int)((DateTime.Today - DateofBirth).TotalDays / 365);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
