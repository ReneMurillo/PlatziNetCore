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

        public IActionResult Index()
        {
            var student = new Student { Name = "Altamiro", UniqueId = Guid.NewGuid().ToString()};
            return View(student);
        }
        public IActionResult MultipleStudent()
        {
            var studentList = GenerateStudentsRandom();
            
            return View(studentList);
        }

        private List<Student> GenerateStudentsRandom()
        {
            string[] name1 = {"Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolas"};
            string[] name2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes"};
            string[] surname = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera"};

            var studentsList = from n1 in name1 
                                from n2 in name2
                                from s1 in surname
                                select new Student {Name = $"{n1} {n2} {s1}", UniqueId = Guid.NewGuid().ToString() };

            return studentsList.OrderBy( al => al.UniqueId).ToList();
        }
    }

}