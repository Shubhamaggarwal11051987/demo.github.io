using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDemo.Models
{
    public class CustomerDbOperation
    {
        private List<Customer> Customers;
        public CustomerDbOperation()
        {
            Customers = new List<Customer>()
            {


            new Customer() { Id = 1, Name = "Amit", Email = "A322@gmail.com", Mobile = "12789695", Gender = "Male" },
             new Customer(){ Id = 1,Name = "Annu",Email = "erwsfA@gmail.com",Mobile = "058789695",Gender = "Male"},
              new Customer(){ Id = 1,Name = "Ankit",Email = "Asdf@gmail.com",Mobile = "1458789695",Gender = "Male"},
             new Customer() { Id = 1,Name = "Deep",Email = "Add@gmail.com",Mobile = "9658789695",Gender = "Female"}
        };
        }

        public List<Customer> GetCustomers()
        {
            return this.Customers;
        }
    }
}
