using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Students
    {
            [ScaffoldColumn(false)]
            [Key]
            public int studentId { get; set; }
         
            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "First Name")]                           
            public string FirstMidName { get; set; }

        [Display(Name = "Schedule key")]
        public string CRN { get; set; }

        [Display(Name = "Course Name")]
        public string CourseId { get; set; }

    }
}
