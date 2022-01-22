using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace TP4MVC.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
     
        public DbSet<Customer> customers { get; set; }
        public DbSet<Employee  >Employees { get; set; }
        public DbSet<Location> Location { get; set; }
    
    }
}
