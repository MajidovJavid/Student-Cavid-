using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
