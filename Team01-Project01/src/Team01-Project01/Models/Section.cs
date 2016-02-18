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
        public int sectionId { get; set; }

        [Range(0,41)]
        [Display(Name ="Capacity")]
        public int capacity { get; set;  }


        [Required]
        [Display(Name = "location key")]
        public string locationId { get; set; }

        [Display(Name = "course key")]
        public string courseId { get; set; }

        [Display(Name = "Faculty key")]
        public string facultyId { get; set; }
    }
}
