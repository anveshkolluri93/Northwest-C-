using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Faculty
    {
        [ScaffoldColumn(false)]
        [Key]
        public int FacultyId { get; set; }
        [Required]

        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "FirstName")]
        public string FirstMidName { get; set; }


    }
}
