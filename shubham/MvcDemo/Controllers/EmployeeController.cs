using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var emp = new List<string>() { "Amit", "Annu", "Deepak", "Deep" };
            ViewBag.employees = emp;
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
