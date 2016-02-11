using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Courses
    {
        [ScaffoldColumn(false)]
        public int CourseId { get; set; }
        [Required]
       
        [Display(Name = "Course Name")]
        public string courseName { get; set; }

        [Display(Name = "creditHours")]
        public string creditHours{ get; set; }

    }
}
