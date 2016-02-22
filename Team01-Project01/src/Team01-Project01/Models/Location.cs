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
        public int locationId { get; set; }
        [Required]
        [Display(Name = "building Id")]
        public string buildingId { get; set; }

        [Display(Name = "Room Number")]
        public string roomNumber { get; set; }

    }
}
