using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Students
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [ScaffoldColumn(false)]
            [Key]
            public int studentId { get; set; }
         
            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "First Name")]                           
            public string FirstMidName { get; set; }

        [Display(Name = "Schedule key")]
        public string CRN { get; set; }


        [Display(Name = "Course Name")]
        public string CourseId { get; set; }

        

        public static List<Students> ReadAllFromCSV(string filepath)
        {
            List<Students> lst = File.ReadAllLines(filepath)
                                         .Skip(1)
                                         .Select(v => Students.OneFromCsv(v))
                                         .ToList();
            return lst;
        }
        public static Students OneFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            Students item = new Students();

            int i = 0;
            item.studentId = Convert.ToInt32(values[i++]);
            item.LastName = Convert.ToString(values[i++]);
            item.FirstMidName = Convert.ToString(values[i++]);
            item.CRN = Convert.ToString(values[i++]);
            item.CourseId = Convert.ToString(values[i++]);
            return item;
        }

    }
}
