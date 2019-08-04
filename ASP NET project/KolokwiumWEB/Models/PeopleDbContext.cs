using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KolokwiumWEB.Models
{
    public class PeopleDbContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Rabat> Rabats { get; set; }

    }
}