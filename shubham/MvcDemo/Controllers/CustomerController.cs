using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcDemo.Models;
namespace MvcDemo.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext dbContext;
        public CustomerController(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            // var Customers = dbContext.customers.ToList();
            var locations = dbContext.Locations.ToList();
            return View(locations);
        }
        public IActionResult CustomerList(int id)
        {
            var customers = dbContext.customers.Where(e => e.Location.Id == id);
            return View(customers);
        }
        public IActionResult CustomerDetail(int id)
        {
            var customer = dbContext.customers.SingleOrDefault(e => e.Id == id);
            return View(customer);
        }

    }
}
