using System;

namespace platziNetCore.Models
{  
    public class Evaluation: SchoolObjectBase
    {
        public Student Student { get; set; }
        public string StudentId { get; set; }
        public Subject Subject { get; set; }
        public string SubjectId { get; set; }
        
        public float Score { get; set; }

        public override string ToString() 
        {
            return $"{Score}, {Student.Name}, {Subject.Name}";
        }
    }
}