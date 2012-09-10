using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootstrappingMvc.Models
{
    public class MoviePassViewModel
    {
        public MoviePassViewModel()
        {
            // eventually do something interesting here...
        }


        public MoviePass MoviePass { get; set; }
        public string PossibleMoviesJson { get; set; }

    }
}