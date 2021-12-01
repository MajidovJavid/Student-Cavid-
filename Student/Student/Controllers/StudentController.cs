using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return Content("Id is null");
            }

            return Json(new { Name = "Barak", Surname = "Obama", Age = 23 });
        }


    }
}
