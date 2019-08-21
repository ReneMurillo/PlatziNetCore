using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using platziNetCore.Models;

namespace platziNetCore.Controllers
{
    public class CourseController : Controller
    {
        private SchoolContext _context;

        public CourseController(SchoolContext context)
        {
            _context = context;
        }

        [Route("Course/")]
        [Route("Course/{courseId}")]
        [Route("Course/Index")]
        [Route("Course/Index/{courseId}")]
        public IActionResult Index(string courseId)
        {
            if(!string.IsNullOrWhiteSpace(courseId))
            {
                return View(_context.Courses.Find(courseId));
            }
            else
            {
                return View("MultipleCourse", _context.Courses);
            }
            
        }
        public IActionResult MultipleCourse()
        {
            return View(_context.Courses);
        }
    }

}