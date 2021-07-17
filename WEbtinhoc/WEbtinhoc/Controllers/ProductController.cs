using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEbtinhoc.Models;

namespace WEbtinhoc.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Detail/
        THIETBIMOIEntities db= new THIETBIMOIEntities();
        public ActionResult Product()
        {
            List<sanpham>sp = db.sanphams.ToList();
            return View(sp);
        }
        public ActionResult Detail(string id)
        {
            var Product = db.sanphams.SingleOrDefault(u => u.IDSP == id);
            if (Product != null)
            {
                
                return View(Product);

            }
            return RedirectToAction("Index", "Home");
        }


        public ActionResult Products(string loai = "")
        {
            
            ViewBag.loai = loai;
           


            var ListProduct = new List<sanpham>();
            if (loai == "")
            {
                ListProduct = db.sanphams.ToList();
                ViewBag.Name = "Danh Sách Sản Phẩm";
            }
            else
            {
                
                    ListProduct = db.sanphams.Where(t => t.IDLOAI == loai).ToList();
                    var Loai = db.loais.Single(t => t.IDLOAI == loai);
                    ViewBag.Name = Loai.TENLOAI;
                
            }
           
            return View(ListProduct);
        }

        

    }
}
