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
    
    public partial class tinhtrang
    {
        public tinhtrang()
        {
            this.sanphams = new HashSet<sanpham>();
        }
    
        public string IDTINHTRANG { get; set; }
        public string TENTINHTRANG { get; set; }
    
        public virtual ICollection<sanpham> sanphams { get; set; }
    }
}