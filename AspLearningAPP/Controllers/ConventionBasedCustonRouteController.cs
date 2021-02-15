using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspLearningAPP.Controllers
{
    public class ConventionBasedCustonRouteController : Controller
    {
        // GET: ConventionBasedCustonRoute
        /*
         Check route.config for information
             */
        public ActionResult Index()
        {
            return View();
        }

        /*
         Asp.Net MVC attribute ROute constraints.(Search on google to get route constraints)
         To Enable custom routes put routes.MapMvcAttributeRoutes() in route.config
             */
        [Route("ConventionBasedCustonRoute/ByReleaseDate/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(string year,string month)
        {
            return Content(string.Format("Year is {0} and month is {1}",year,month));
        }

    }
}