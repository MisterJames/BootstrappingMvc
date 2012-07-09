using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrappingMvc.Models;

namespace BootstrappingMvc.Controllers
{
    public class MoviePassController : Controller
    {
        //
        // GET: /MoviePass/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /MoviePass/Details/5

        public ActionResult Details(int? id)
        {
            MoviePass pass = new MoviePass
            {
                MovieTitle = "The Last Starfighter",
                CanUseForNewReleases = true,
                CanSkipLine = false
            };

            return View(pass);
        }

        //
        // GET: /MoviePass/Create

        public ActionResult Create()
        {
            MoviePass pass = new MoviePass
            {
                CanUseForNewReleases = true,
                CanSkipLine = false
            };

            return View(pass);
        }

        //
        // POST: /MoviePass/Create

        [HttpPost]
        public ActionResult Create(MoviePass moviePass)
        {
            return View(moviePass);
        }

        //
        // GET: /MoviePass/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /MoviePass/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /MoviePass/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /MoviePass/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
