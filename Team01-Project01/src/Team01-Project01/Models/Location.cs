using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
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
        
        [Display(Name = "building Id")]
        public string buildingId { get; set; }

        [Display(Name = "Room Number")]
        public string roomNumber { get; set; }

        public virtual ICollection<Schedule> Schedules { get; set; }


        public static List<Location> ReadAllFromCSV(string filepath)
        {
            List<Location> lst = File.ReadAllLines(filepath)
                                         .Skip(1)
                                         .Select(v => Location.OneFromCsv(v))
                                         .ToList();
            return lst;
        }
        public static Location OneFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Location item = new Location();

            int i = 0;
            item.LocationId = Convert.ToInt32(values[i++]);
            item.buildingId = Convert.ToString(values[i++]);
            item.roomNumber = Convert.ToString(values[i++]);
           
            return item;
        }
    }
}
