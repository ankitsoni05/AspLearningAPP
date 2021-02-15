using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspLearningAPP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public string GetDetails(string id, string name)
        {
            string queryStringValue = Request.QueryString["name"];
            return "Get Details Invoked id is : " + id + " and name is : " + queryStringValue + "  " + name;
        }

        public ContentResult getContents()
        {
            return Content("Hello");
        }
        public RedirectResult GetRecidrect()
        {
            return Redirect("https://www.netflorist.co.za/");
        }
        public RedirectToRouteResult GetRedirectToRoute()
        {
            return RedirectToAction("Index", "Home",new { sortBy= "Name"});
        }
        public HttpNotFoundResult GetNotFoundResult()
        {
            return HttpNotFound("Contents not found");
        }


    }
}