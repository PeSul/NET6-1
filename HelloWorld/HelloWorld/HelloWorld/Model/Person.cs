using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    class Person
    {
        public Person()
        {
            
        }

        public Person(string firtname, string lastname)
        {
            FirstName = firtname;
            LastName = lastname;
        }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public DateTime DateofBirth { get; set; }

        public int Age()
        {
            return (int)((DateTime.Today - DateofBirth).TotalDays / 365);
        }
    }
}
