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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class THIETBIEntities : DbContext
    {
        public THIETBIEntities()
            : base("name=THIETBIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<cthd> cthds { get; set; }
        public DbSet<ctpn> ctpns { get; set; }
        public DbSet<hoadon> hoadons { get; set; }
        public DbSet<loai> loais { get; set; }
        public DbSet<nguoidung> nguoidungs { get; set; }
        public DbSet<nhacc> nhaccs { get; set; }
        public DbSet<nhanvien> nhanviens { get; set; }
        public DbSet<phieunhap> phieunhaps { get; set; }
        public DbSet<sanpham> sanphams { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<thuonghieu> thuonghieux { get; set; }
        public DbSet<tinhtrang> tinhtrangs { get; set; }
        public DbSet<vaitro> vaitroes { get; set; }
    }
}
