using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ScaffoldColumn(false)]
        [Required]
        [Key]
        public int LocationId { get; set; }
        [Required]
        [Display(Name = "building Id")]
        public string buildingId { get; set; }

        [Display(Name = "Room Number")]
        public string roomNumber { get; set; }
        
    }
}
