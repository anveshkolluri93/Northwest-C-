﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Location
    {
        [ScaffoldColumn(false)]
        public int LocationId { get; set; }
        [Required]
        [Display(Name = "building ")]
        public string buildingId { get; set; }

        [Display(Name = "Room ")]
        public string roomNumber { get; set; }

    }
}