using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Team01_Project01.Models
{
    public class Courses
    {
        
        [ScaffoldColumn(false)]
        [Key]
        public int CoursesId { get; set; }
        
        [Display(Name = "CourseName")]                  
        public string courseName { get; set; }

        [Display(Name = "course Duration")]
        public string duration{ get; set; }

        [Display(Name = "credit Hours")]
        public double credits { get; set; }

        public static List<Courses> ReadAllFromCSV(string filepath)
        {
            List<Courses> lst = File.ReadAllLines(filepath)
                                         .Skip(1)
                                         .Select(v => Courses.OneFromCsv(v))
                                         .ToList();
            return lst;
        }
        public static Courses OneFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Courses item = new Courses();

            int i = 0;
            item.CoursesId = Convert.ToInt32(values[i++]);
            item.courseName = Convert.ToString(values[i++]);
            item.duration = Convert.ToString(values[i++]);
            item.credits = Convert.ToDouble(values[i++]);
           
            return item;
        }
    }
}
