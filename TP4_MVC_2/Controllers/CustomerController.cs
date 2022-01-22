using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP4_MVC_2.Models;

namespace TP4_MVC_2.Controllers
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
            // string message = "I am dynamic content...";
            // ViewBag.msg = message;
            //ViewData["data"] = message;

            //  var customers = new List<string>() { "Ajay","Manish","Suraj","Rohit","pawan"};
            //  ViewBag.customer = customers;
            // ViewData["customer"] = customers;
            var customers = dbContext.customers.ToList();
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        } 
        
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            dbContext.customers.Add(customer);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeletCustomer(int id)
        {
            var cust = dbContext.customers.SingleOrDefault(e => e.Id == id);
            dbContext.customers.Remove(cust);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
