using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
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

        public virtual ICollection<Section> Sections { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }

        public static List<Faculty> ReadAllFromCSV(string filepath)
        {
            List<Faculty> lst = File.ReadAllLines(filepath)
                                         .Skip(1)
                                         .Select(v => Faculty.OneFromCsv(v))
                                         .ToList();
            return lst;
        }
        public static Faculty OneFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Faculty item = new Faculty();

            int i = 0;
            item.FacultyId = Convert.ToInt32(values[i++]);
            item.LastName = Convert.ToString(values[i++]);
            item.FirstMidName = Convert.ToString(values[i++]);
            

            return item;
        }

    }

}
