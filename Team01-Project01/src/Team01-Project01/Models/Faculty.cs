using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Faculty
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ScaffoldColumn(false)]
        [Required]
        [Key]
        public int FacultyId { get; set; }
        

        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "FirstName")]
        public string FirstMidName { get; set; }


    }
}
