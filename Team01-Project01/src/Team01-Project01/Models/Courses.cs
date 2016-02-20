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

        [Display(Name = "course Duration")]
        public string duration{ get; set; }

        [Display(Name = "credit Hours")]
        public string credits { get; set; }


    }
}
