using System;
using System.Collections.Generic;

namespace platziNetCore.Models
{  
    public class Student: SchoolObjectBase
    {
        public List<Evaluation> Evaluations {get; set;} = new List<Evaluation>();

    }
}