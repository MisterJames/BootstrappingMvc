using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrappingMvc.Models;

namespace BootstrappingMvc.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/

        public ActionResult Index()
        {
            var repository = new FakeMovieRepository();
            return View(repository.GetMovies().OrderBy(m=>m.YearReleased));
        }

    }
}
