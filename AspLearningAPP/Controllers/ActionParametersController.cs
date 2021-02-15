using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspLearningAPP.Controllers
{
    public class ActionParametersController : Controller
    {
        /*
         Action parameters or parameter binding is nothing but the way to send parameters to action method.
         1. Can be inform of URL :- /Home/Index/1
         2. Can be query string  :- /home/Index/?id=1
         3. Can be in the form of form data.
             */
        // GET: ActionParameters
        public ActionResult Index(int id)
        {
            return Content("Id is "+id);
        }

        //Optional parameters
        //http://localhost/AspLearningAPP/ActionParameters/OptionalParams/?pageIndex=4&SortBy=Date
        //http://localhost/AspLearningAPP/ActionParameters/OptionalParams/

        /*
         http://localhost/AspLearningAPP/ActionParameters/OptionalParams/4/Date
         URL in this case cannot be like this because my route config only says id as parameter, so to achieve this we need to provide custom
         routes.
             */
        public ActionResult OptionalParams(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("PageIndex={0}&SortBy={1}", pageIndex, sortBy));
        }
    }
}