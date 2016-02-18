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
        [Required]
        [Key]
        public int courseId { get; set; }
        
       
        [Display(Name = "Course Name")]                  
        public string courseName { get; set; }

        [Display(Name = "courseDuration")]
        public string duration{ get; set; }

        [Display(Name = "creditHours")]
        public string credits { get; set; }


    }
}
