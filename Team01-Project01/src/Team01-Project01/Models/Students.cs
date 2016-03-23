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
            public int StudentsId { get; set; }
            
            [Required]
            [Display(Name = "Last Name")]
            public string LastName { get; set; }

            [Display(Name = "First Name")]                           
            public string FirstMidName { get; set; }

            public int CoursesId { get; set; }
            public virtual Courses Courses { get; set; }



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
            item.StudentsId = Convert.ToInt32(values[i++]);
            item.LastName = Convert.ToString(values[i++]);
            item.FirstMidName = Convert.ToString(values[i++]);
            item.CoursesId = Convert.ToInt32(values[i++]);
            return item;
        }

    }
}
