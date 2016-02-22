using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity.ChangeTracking;
using System.ComponentModel.DataAnnotations;

namespace DataAnveshkumarKolluri.Models
{
    public class Location
    {
        [ScaffoldColumn(false)]
        [Key]
        public int LocationID { get; set; }
        [Display(Name = "Country")]
        public string Country { get; set; }
        [Display(Name = "Place")]
        public string Place { get; set; }
        [Display(Name = "State ")]
        public string State { get; set; }
        [Display(Name = "State Abbreviation")]
        public string StateAbbreviation { get; set; }
        [Display(Name = "County")]
        public string County { get; set; }
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }
        [Display(Name = "Latitude")]
        public double Latitude { get; set; }
        [Display(Name = "Longitude")]
        public double Longitude { get; set; }
    }

}
