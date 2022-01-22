using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TP4MVC.Models;

namespace TP4MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContext;

        public IHostingEnvironment Environment { get; }

        public EmployeeController(ApplicationDbContext context, IHostingEnvironment environment)
        {
            dbContext = context;
            Environment = environment;
        }
        public IActionResult Index()
        {
            var emps = dbContext.Employees.ToList();
            return View(emps);
        }
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
           
             var files= Request.Form.Files;
            string dbPath = string.Empty;
            if (files.Count > 0)
            {
                string path = Environment.WebRootPath;
                string fullpath = Path.Combine(path, "images", files[0].FileName);
                dbPath = "images/" + files[0].FileName;
                FileStream stream = new FileStream(fullpath,FileMode.Create);
                files[0].CopyTo(stream);
            }

            employee.Image = dbPath;
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Details()
        {
            return View();
        }
    }
}
