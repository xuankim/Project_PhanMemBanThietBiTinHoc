//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEbtinhoc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class cthd
    {
        public int IDHD { get; set; }
        public string IDSP { get; set; }
        public int SOLUONG { get; set; }
    
        public virtual hoadon hoadon { get; set; }
        public virtual sanpham sanpham { get; set; }
    }
}
