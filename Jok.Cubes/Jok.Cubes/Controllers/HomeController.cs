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
                Description = "Cubes are objects with two dimmension properties: colors (4 color) and levels (9 level)",
                Repository = "https://github.com/jokio/jok-cubes.git",
                CSS = Request.Url.ToString() + "css/v1"

            }, JsonRequestBehavior.AllowGet);
        }
    }
}