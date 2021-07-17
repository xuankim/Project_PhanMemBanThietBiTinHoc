using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEbtinhoc.Models;

namespace WEbtinhoc.Controllers
{
    public class CategoriesController : Controller
    {
        //
        // GET: /Categories/
        THIETBIMOIEntities db = new THIETBIMOIEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MenuPartial()
        {
            ViewBag.Loai = db.loais.OrderBy(t => t.TENLOAI).ToList();
            ViewBag.ThuongHieu = db.thuonghieux.OrderBy(t => t.TENTHUONGHIEU).ToList();
            return PartialView();
        }
    }
}
