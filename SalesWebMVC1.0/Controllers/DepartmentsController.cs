using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC1._0.Models;

namespace SalesWebMVC1._0.Controllers
{
    public class DepartmentsController : Controller
{
    public IActionResult Index()
    {
            List<Department> list = new List<Department>();
            list.Add(new Department/*instanciação automática*/ { Id = 1, Name = "Eletro" });
            list.Add(new Department/*instanciação automática*/ { Id = 2, Name = "Fashion" });


                return View(list);//enviando dados do controller para view
    }
}
}
