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

        [Route("Student/")]
        [Route("Student/{studentId}")]
        [Route("Student/Index")]
        [Route("Student/Index/{studentId}")]
        public IActionResult Index(string studentId)
        {
            if(!string.IsNullOrWhiteSpace(studentId))
            {
                return View(_context.Students.Find(studentId));
            }
            else
            {
                return View("MultipleStudent", _context.Students);
            }
            
        }
        public IActionResult MultipleStudent()
        {
            return View(_context.Students);
        }
    }

}