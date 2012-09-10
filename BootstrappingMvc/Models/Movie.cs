using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BootstrappingMvc.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
                
        public string Title { get; set; }

        public string Director { get; set; }

        [Range(1895, 2015)]
        public int YearReleased { get; set; }

        public string PosterImage { get; set; }

    }
}