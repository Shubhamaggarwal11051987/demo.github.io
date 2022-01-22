using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP4MVC.Models
{
    public class CustomerDbOperation
    {
        private List<Customer> Customers;
        public CustomerDbOperation()
        {
            Customers = new List<Customer>()
            {
                new Customer(){Id=1,Name="deepak",Email="deepak232@gmail.com",Mobile="895238322",Gender="Male"},
                new Customer(){Id=2,Name="Rakesh",Email="rakesh232@gmail.com",Mobile="805238322",Gender="Male"},
                new Customer(){Id=3,Name="Amit",Email="amitt232@gmail.com",Mobile="888238322",Gender="Male"},

            };
        }
        public List<Customer> GetCustomers()
        {
            return this.Customers;
        }

        public Customer AddCustomer(Customer obj)
        {
            this.Customers.Add(obj);
            return obj;
        }
    }
}
