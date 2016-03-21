using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Team01_Project01.Models
{

    public class Section
    {

        [ScaffoldColumn(false)]
        [Key]
        public int SectionId { get; set; }

        [Range(0,41)]
        [Display(Name ="Capacity")]
        public int capacity { get; set;  }


        [Required]
        [Display(Name = "Location key")]
        public string LocationId { get; set; }
        public virtual Location Location { get; set; }

        [Display(Name = "Course key")]
        public string CoursesId { get; set; }
        public virtual Courses Courses { get; set; }

        [Display(Name = "Faculty key")]
        public string FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }



    }
}
