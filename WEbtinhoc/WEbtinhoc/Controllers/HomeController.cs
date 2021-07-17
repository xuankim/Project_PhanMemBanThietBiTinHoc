using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEbtinhoc.Models;

namespace WEbtinhoc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        THIETBIMOIEntities db = new THIETBIMOIEntities();
        public ActionResult Index()
        {
            return View();
        }
        


    }
}
