using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace Team01_Project01.Models
{

    public class Section
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ScaffoldColumn(false)]
        [Key]
        public int SectionId { get; set; }

        [Range(0,100)]
        [Display(Name ="Capacity")]
        public int capacity { get; set;  }

        public int CoursesId { get; set; }
        public virtual Courses Courses { get; set; }
        
        public int FacultyId { get; set; }
        public virtual Faculty Faculties { get; set; }

        public static List<Section> ReadAllFromCSV(string filepath)
        {
            List<Section> lst = File.ReadAllLines(filepath)
                                         .Skip(1)
                                         .Select(v => Section.OneFromCsv(v))
                                         .ToList();
            return lst;
        }
        public static Section OneFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Section item = new Section();
            int i = 0;
            item.SectionId = Convert.ToInt32(values[i++]);
            item.capacity = Convert.ToInt32(values[i++]);
            item.CoursesId = Convert.ToInt32(values[i++]);
            item.FacultyId = Convert.ToInt32(values[i++]);
         
            return item;
        }
    }
}
