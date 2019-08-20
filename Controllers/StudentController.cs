using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using platziNetCore.Models;

namespace platziNetCore.Controllers
{
    public class StudentController : Controller
    {
        private SchoolContext _context;

        public StudentController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Students.FirstOrDefault());
        }
        public IActionResult MultipleStudent()
        {
            return View(_context.Students);
        }
    }

}