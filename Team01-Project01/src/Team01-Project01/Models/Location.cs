using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Location
    {
        [ScaffoldColumn(false)]
        [Key]
        public int LocationId { get; set; }
        

        [Display(Name = "buildingName")]
        public string buildingName { get; set; }

        [Display(Name = "Room Number")]
        public string roomNumber { get; set; }
        
    }
}
