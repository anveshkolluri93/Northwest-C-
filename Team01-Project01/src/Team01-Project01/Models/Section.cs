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

        [Range(0,50)]
        [Display(Name ="Capacity")]
        public int capacity { get; set;  }

        [Display(Name = "Faculty Name")]
        public string FacultyId { get; set; }

        [Required]
        [Display(Name = "Room")]
        public string roomNumber { get; set; }
    }
}
