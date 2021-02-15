using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspLearningAPP.Models;

namespace AspLearningAPP.Controllers
{
    public class PassingDataToViewController : Controller
    {
        // GET: PassingDataToView
        public ActionResult Index()
        {
            Movies movies = new Movies() { MovieName = "The Mechanic", ReleaseYear = "2014" };

            /*
             Passing Data to view using viewData
             View Data uses a magic string.
             */
            ViewData["Movies"] = movies;

            /*
             Passing data to view using viewbag
             viewbag uses a magic property.
             Here again typecasting is required
             */
            ViewBag.Movies = movies;
            return View(movies);
        }
    }
}