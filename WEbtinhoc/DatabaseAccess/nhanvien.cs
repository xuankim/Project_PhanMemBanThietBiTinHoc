//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class nhanvien
    {
        public nhanvien()
        {
            this.phieunhaps = new HashSet<phieunhap>();
        }
    
        public string IDNV { get; set; }
        public int HSL { get; set; }
        public byte[] TINHTRANG { get; set; }
    
        public virtual nguoidung nguoidung { get; set; }
        public virtual ICollection<phieunhap> phieunhaps { get; set; }
    }
}