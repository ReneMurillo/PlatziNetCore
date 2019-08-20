using System;
using System.Collections.Generic;

namespace platziNetCore.Models
{  
    public class Subject: SchoolObjectBase
    {
        public string CourseId { get; set; }

        public Course Course { get; set; }

        public List<Evaluation> Evaluations { get; set; }
    }
}