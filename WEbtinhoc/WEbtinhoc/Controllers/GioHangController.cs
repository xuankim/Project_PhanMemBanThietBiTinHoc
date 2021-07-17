using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEbtinhoc.Models;

namespace WEbtinhoc.Controllers
{
    public class GioHangController : Controller
    {
        //
        // GET: /GioHang/

        public ActionResult checkout()
        {
            return View();
        }
        public ActionResult checkoutt()
        {
            if (Session["Cart"] == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<Cart> lstCart = getCart();
            if (lstCart.Count == 0)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.SubTotal = SubTotal();
            return View(lstCart);
        }
        private double SubTotal()
        {
            double sub = 0;
            List<Cart> lstCart = Session["Cart"] as List<Cart>;
            if (lstCart != null)
            {
                sub = lstCart.Sum(sp => sp.dSubtotal);
            }
            return sub;
        }

        public List<Cart> getCart()
        {
            List<Cart> lstCart = Session["Cart"] as List<Cart>;
            if (lstCart == null)
            {
                lstCart = new List<Cart>();
                Session["Cart"] = lstCart;
            }
            return lstCart;
        }
    }
}
