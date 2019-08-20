using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using platziNetCore.Models;

namespace platziNetCore.Controllers
{
    public class SubjectController : Controller
    {
        private SchoolContext _context;

        public SubjectController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Subjects.FirstOrDefault());
        }
        public IActionResult MultipleSubject()
        {
            return View(_context.Subjects);
        }
    }

}