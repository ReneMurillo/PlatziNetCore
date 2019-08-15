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

        public IActionResult Index()
        {
            var subject = new Subject { Name = "Programming", UniqueId = Guid.NewGuid().ToString()};
            return View(subject);
        }
        public IActionResult MultipleSubject()
        {
            List<Subject> subjectList = new List<Subject>(){
                    new Subject { Name = "Mathematics", UniqueId = Guid.NewGuid().ToString()},
                    new Subject { Name = "Sports", UniqueId = Guid.NewGuid().ToString()},
                    new Subject { Name = "Spanish", UniqueId = Guid.NewGuid().ToString()},
                    new Subject { Name = "Science", UniqueId = Guid.NewGuid().ToString()},
                    new Subject { Name = "Programming", UniqueId = Guid.NewGuid().ToString()}
                };
            
            return View(subjectList);
        }
    }

}