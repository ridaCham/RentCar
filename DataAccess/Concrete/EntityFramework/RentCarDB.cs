using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentCarDB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentCarDB;trusted_connection=true");

            //UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=RentCarDB;trusted_connection=true");

        }
        public DbSet<Car> cars { get; set; }
        public DbSet<Color> colors { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> rentals { get; set; }

    }
}
