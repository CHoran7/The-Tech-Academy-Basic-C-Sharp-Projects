using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step248
{
    class MyContext : DbContext
    {
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Start> Starts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }
}
