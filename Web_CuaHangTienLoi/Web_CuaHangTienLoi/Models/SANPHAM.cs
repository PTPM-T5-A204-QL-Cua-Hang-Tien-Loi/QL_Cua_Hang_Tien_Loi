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
    
    public partial class SANPHAM
    {
        public SANPHAM()
        {
            this.CHITIETHDBANs = new HashSet<CHITIETHDBAN>();
            this.CHITIETNHAPHANGs = new HashSet<CHITIETNHAPHANG>();
        }
    
        public string MASP { get; set; }
        public string TENSP { get; set; }
        public string DONVI { get; set; }
        public int SOLUONG { get; set; }
        public double DONGIABAN { get; set; }
        public byte[] HINHANH { get; set; }
        public string MALOAI { get; set; }
        public string MANCC { get; set; }
    
        public virtual ICollection<CHITIETHDBAN> CHITIETHDBANs { get; set; }
        public virtual ICollection<CHITIETNHAPHANG> CHITIETNHAPHANGs { get; set; }
        public virtual LOAISP LOAISP { get; set; }
        public virtual NHACUNGCAP NHACUNGCAP { get; set; }
    }
}
