using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SampleDummy.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Display(Name ="The Actor's Name")]
        public string ActorName { get; set; }

        [Display(Name = "The Movie")]
        public string MovieName { get; set; }

        [Display(Name = "Genre")]
        public string Genre { get; set; }
    }
}
