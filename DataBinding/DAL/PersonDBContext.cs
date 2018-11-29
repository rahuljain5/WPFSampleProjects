using DataBinding.Entitites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBinding.DAL
{
    public class PersonDBContext : DbContext
    {
        public DbSet<Person> People { get; set; }
    }
}
