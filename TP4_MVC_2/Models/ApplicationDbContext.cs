using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP4_MVC_2.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        public DbSet<Customer> customers { get; set; }
        public DbSet<Department > Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
