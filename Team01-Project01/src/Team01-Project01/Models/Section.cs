using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Section
    {
        [ScaffoldColumn(false)]
        public int SectionId { get; set; }
        [Required]
        [Display(Name = "Room")]
        public string roomNumber { get; set; }

        [Display(Name = "Faculty Name")]
        public string FacultyId { get; set; }

    }
}
