//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ChitietdonhangOnl
    {
        public int Madon { get; set; }
        public string MASP { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<decimal> Dongia { get; set; }
        public Nullable<decimal> Thanhtien { get; set; }
    
        public virtual DonhangOnl DonhangOnl { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}