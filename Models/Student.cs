using System;
using System.Collections.Generic;

namespace platziNetCore.Models
{  
    public class Student: SchoolObjectBase
    {
        public List<Evaluation> Evaluations {get; set;} 

        public string CourseId { get; set; }

        public Course Course { get; set; }

    }
}