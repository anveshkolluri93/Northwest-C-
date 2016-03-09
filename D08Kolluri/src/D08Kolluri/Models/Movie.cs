using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace D08Kolluri.Models
{
    public class Movie
    {
        [ScaffoldColumn(false)]

        public int MovieID { get; set; }

        [Display(Name = "Movie's Title")]
        public string MovieTitle { get; set; }
        [Display(Name = "Movie Reviews")]
        public string MovieReviews { get; set; }

        [Display(Name = "Genre")]
        public string MovieGenre { get; set; }

        [Display(Name = "ActorName")]
        public string ActorName { get; set; }

        [Display(Name = "ActressName")]
        public string ActressName { get; set; }

    }
}
