using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Courses
    {
        [ScaffoldColumn(false)]
        public int CourseId { get; set; }
        [Required]
        [Display(Name = "Student Details")]
        public string StudentId { get; set; }

        [Display(Name = "Faculty Details")]
        public string FacultyId { get; set; }

    }
}
