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

        [Route("Subject/Index")]
        [Route("Subject/Index/{subjectId}")]
        public IActionResult Index(string subjectId)
        {
            if(!string.IsNullOrWhiteSpace(subjectId))
            {
                return View(_context.Subjects.Find(subjectId));
            }
            else
            {
                return View("MultipleSubject", _context.Subjects);
            }
        }
        public IActionResult MultipleSubject()
        {
            return View(_context.Subjects);
        }
    }

}