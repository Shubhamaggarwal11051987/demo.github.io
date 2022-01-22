using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TP4_MVC_2.Models;

namespace TP4_MVC_2.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContext;
        public EmployeeController(ApplicationDbContext application)
        {
            dbContext = application;
        }
        public IActionResult Index()
        {
            var departments = dbContext.Departments.ToList();
            return View(departments);
        }

        public IActionResult EmployeeList(int id)
        {
            var employees = dbContext.Employees.Where(e => e.Department.Id == id);
            return View(employees);

        }

        public IActionResult EmployeeDetail(int id)
        {
            Employee employee = dbContext.Employees.SingleOrDefault(e => e.Id == id);
            return View(employee);
        }
    }
}
