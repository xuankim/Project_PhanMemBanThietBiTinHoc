using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEbtinhoc.Models
{
    public class Cart
    {
        THIETBIMOIEntities db = new THIETBIMOIEntities();

        public string idProduct { set; get; }
        public string nName { set; get; }
        public string iImage { set; get; }
        public double pPrice { set; get; }
        public int iQuantity { set; get; }
        public double dSubtotal
        {
            get { return iQuantity * pPrice; }
        }

        // Khởi tạo giỏ hàng
        public Cart(string idPro)
        {
            idProduct = idPro;
            sanpham product = db.sanphams.Single(s => s.IDSP == idProduct);
            nName = product.TENSP;
            iImage = product.ANHSP;
            pPrice = double.Parse(product.GIATIEN.ToString());
            iQuantity = 1;
        }
    }
}