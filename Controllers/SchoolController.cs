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
            school.UniqueId = Guid.NewGuid().ToString();
            school.Name = "PlatziSchool";
            school.City = "Bogota";
            school.Address = "Avenue always leave";
            school.Country = "Colombia";
            school.SchoolType = SchoolType.HighSchool;
            return View(school);
        }
    }

}