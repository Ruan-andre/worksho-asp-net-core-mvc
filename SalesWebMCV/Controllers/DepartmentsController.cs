using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMCV.Models;

namespace SalesWebMCV.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> dep = new List<Department>();
            dep.Add(new Department { Id = 1, Name = "Eletronics" });
            dep.Add(new Department { Id = 2, Name = "Fashion" });
            return View(dep);
        }
    }
}