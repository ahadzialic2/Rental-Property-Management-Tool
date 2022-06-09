using Microsoft.EntityFrameworkCore;
using Rental_Property_Management_Tool.Models;

namespace Rental_Property_Management_Tool.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<RentalProperty> RentalProperties { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<OverheadCost> OverheadCosts { get; set; }
    }
}
