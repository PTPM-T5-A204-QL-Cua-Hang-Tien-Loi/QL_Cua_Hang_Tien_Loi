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
    
    public partial class LOAISP
    {
        public LOAISP()
        {
            this.SANPHAMs = new HashSet<SANPHAM>();
        }
    
        public string MALOAI { get; set; }
        public string TENLOAI { get; set; }
    
        public virtual ICollection<SANPHAM> SANPHAMs { get; set; }
    }
}
