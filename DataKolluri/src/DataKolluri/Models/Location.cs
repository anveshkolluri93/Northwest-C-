using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataKolluri.Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Country { get; set; }
        public string Place { get; set; }
        public string State { get; set; }
        public string StateAbbreviation { get; set; }
        public string County { get; set; }
        public string ZipCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
