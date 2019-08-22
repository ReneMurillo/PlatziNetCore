using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace platziNetCore.Models
{
    public class Course: SchoolObjectBase
    {
        [Required]
        [StringLength(5, ErrorMessage="The field {0} can't contain more than 5 letters.")]
        public override string Name { get; set; }
        public JourneyType Journey { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Student> Students { get; set; }

        [Required]
        [Display(Prompt="Delivery Address")]
        [MinLength(10, ErrorMessage="The field {0} must contain at least 10 letters.")]
        public string Address { get; set; }

        public string SchoolId { get; set; }

        public School School { get; set; }
    }
}