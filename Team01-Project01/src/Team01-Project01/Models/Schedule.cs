using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Team01_Project01.Models
{
    public class Schedule
    {
[ScaffoldColumn(false)]
            public int ScheduleId { get; set; }
            [Required]
            [Display(Name = "Faculty Available")]
            public string  FacultyId{ get; set; }

        [Display(Name = "Time")]
        public int time { get; set; }

        [Display(Name = "Students Enrolled")]
            public string studentId { get; set; }
      
    



    }
}
