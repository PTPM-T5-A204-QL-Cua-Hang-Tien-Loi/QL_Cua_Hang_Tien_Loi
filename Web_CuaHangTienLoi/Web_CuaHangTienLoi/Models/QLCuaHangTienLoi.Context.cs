﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_CuaHangTienLoi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL_CuaHangTienLoi_NewEntities1 : DbContext
    {
        public QL_CuaHangTienLoi_NewEntities1()
            : base("name=QL_CuaHangTienLoi_NewEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CHITIETHDBAN> CHITIETHDBANs { get; set; }
        public DbSet<CHITIETNHAPHANG> CHITIETNHAPHANGs { get; set; }
        public DbSet<CHUCVU> CHUCVUs { get; set; }
        public DbSet<HDBAN> HDBANs { get; set; }
        public DbSet<KHACH> KHACHes { get; set; }
        public DbSet<LOAISP> LOAISPs { get; set; }
        public DbSet<Nguoidung> Nguoidungs { get; set; }
        public DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public DbSet<NHANVIEN> NHANVIENs { get; set; }
        public DbSet<NHAPHANG> NHAPHANGs { get; set; }
        public DbSet<QUYEN> QUYENs { get; set; }
        public DbSet<SANPHAM> SANPHAMs { get; set; }
        public DbSet<TAIKHOAN> TAIKHOANs { get; set; }
    }
}
