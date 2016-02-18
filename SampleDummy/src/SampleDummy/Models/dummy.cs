using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDummy.Models
{
    public class dummy
    {
        [Key]
        [ScaffoldColumn(false)]
        public int LocationID { get; set; }
    }
}
