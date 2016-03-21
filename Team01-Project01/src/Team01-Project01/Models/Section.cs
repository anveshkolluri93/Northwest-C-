using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team01_Project01.Models
{

    public class Section
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ScaffoldColumn(false)]
        [Required]
        [Key]
        public int SectionId { get; set; }

        [Range(0,41)]
        [Display(Name ="Capacity")]
        public int capacity { get; set;  }

        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        
        public int CoursesID { get; set; }
        public virtual Courses Courses { get; set; }
        
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
