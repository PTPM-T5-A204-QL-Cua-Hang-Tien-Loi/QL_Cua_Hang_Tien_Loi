﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BLL_DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QL_CUAHANGTIENLOIEntities : DbContext
    {
        public QL_CUAHANGTIENLOIEntities()
            : base("name=QL_CUAHANGTIENLOIEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETHDBAN> CHITIETHDBANs { get; set; }
        public virtual DbSet<HANG> HANGs { get; set; }
        public virtual DbSet<HDBAN> HDBANs { get; set; }
        public virtual DbSet<KHACH> KHACHes { get; set; }
        public virtual DbSet<LOAIHANG> LOAIHANGs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
    }
}
