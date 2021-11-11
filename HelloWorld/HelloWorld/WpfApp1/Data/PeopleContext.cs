using HelloWorld.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Data
{
    internal class PeopleContext :DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Cars> Cars { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\pes.PHA\source\repos\PeSul\NET6-1\HelloWorld\HelloWorld\WpfApp1\people.db");
    }
}
