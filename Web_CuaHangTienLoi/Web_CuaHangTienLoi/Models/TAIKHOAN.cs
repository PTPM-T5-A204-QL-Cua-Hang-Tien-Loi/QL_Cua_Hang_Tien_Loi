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
    
    public partial class TAIKHOAN
    {
        public int MATAIKHOAN { get; set; }
        public string TAIKHOAN1 { get; set; }
        public string MATKHAU { get; set; }
        public string EMAIL { get; set; }
        public Nullable<int> MAQUYEN { get; set; }
        public string MANHANVIEN { get; set; }
    
        public virtual NHANVIEN NHANVIEN { get; set; }
        public virtual QUYEN QUYEN { get; set; }
    }
}
