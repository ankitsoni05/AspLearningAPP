using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspLearningAPP
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*
             Here order of route always matters we must define most generic first to most specific.
             */

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    "MoviesByReleaseDate",
            //    "ConventionBasedCustonRoute/ByReleaseDate/{year}/{month}",
            //    new { controller = "ConventionBasedCustonRoute", action = "ByReleaseDate" },
            //    new { year = @"\d{4}", month = @"\d{2}" }
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
