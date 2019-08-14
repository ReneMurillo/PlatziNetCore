using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using platziNetCore.Models;

namespace platziNetCore.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            var school = new School();
            school.FundationYear = 2005;
            school.SchoolId = Guid.NewGuid().ToString();
            school.Name = "PlatziSchool";
            return View(school);
        }
    }

}