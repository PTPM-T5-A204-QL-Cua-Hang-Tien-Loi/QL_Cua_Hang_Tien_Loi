//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class HDBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HDBAN()
        {
            this.CHITIETHDBANs = new HashSet<CHITIETHDBAN>();
        }
    
        public string MAHDBAN { get; set; }
        public string MANHANVIEN { get; set; }
        public System.DateTime NGAYBAN { get; set; }
        public string MAKHACH { get; set; }
        public double TONGTIEN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETHDBAN> CHITIETHDBANs { get; set; }
        public virtual KHACH KHACH { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
