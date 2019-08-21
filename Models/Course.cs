using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace platziNetCore.Models
{
    public class Course: SchoolObjectBase
    {
        [Required]
        public override string Name { get; set; }
        public JourneyType Journey { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }

        public string Address { get; set; }

        public string SchoolId { get; set; }

        public School School { get; set; }
    }
}