using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Schedule
    {
            [ScaffoldColumn(false)]
            [Key]
            [Required]
            [Display(Name = "Course Number")]
            public int CRN { get; set; }

            [Required]
            [Display(Name = "Faculty Available")]
            public string  facultyId{ get; set; }
            
            
            [Display(Name = "Date")]
            public DateTime date { get; set; }
            [Display(Name = "Time")]
            public int time { get; set; }

            [Display(Name = "Students key")]
            [ScaffoldColumn(false)]
            public string studentId { get; set; }

        [Display(Name = "Course key")]
        [ScaffoldColumn(false)]
        public int courseId { get; set; }

        [Display(Name = "Section key")]
            [ScaffoldColumn(false)]
            public int sectionId { get; set; }

            [Display(Name = "Location key")]
            [ScaffoldColumn(false)]
            public string locationId { get; set; }

    }
}
