using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace Jok.Cubes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Json(new
            {
                Name = "Jok Cubes",
                Description = "Objects for creating games",
                Repository = "https://github.com/jokio/jok-cubes.git",
                CSS = Request.Url.ToString() + "css/v1"

            }, JsonRequestBehavior.AllowGet);
        }
    }
}