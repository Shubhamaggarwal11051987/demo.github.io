using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP4_MVC_2.Models
{
    public class CustomerOperation
    {
        public List<Customer> customers;
        public CustomerOperation()
        {
            customers = new List<Customer>()
            {
                new Customer(){Id=1,Name="deepak",Address="noida"},
                new Customer(){Id=2,Name="rahul",Address="noida"},
                new Customer(){Id=3,Name="subham",Address="delhi"},

            };
        }

        public List<Customer> GetCustomers()
        {
            return customers.ToList();
        }
    }
}
