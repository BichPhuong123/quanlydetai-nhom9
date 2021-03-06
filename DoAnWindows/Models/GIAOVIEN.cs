//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAnWindows.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GIAOVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAOVIEN()
        {
            this.DETAIs = new HashSet<DETAI>();
            this.SINHVIENs = new HashSet<SINHVIEN>();
        }
    
        public string MaGV { get; set; }
        public string HoTen { get; set; }
        public string Phai { get; set; }
        public Nullable<System.DateTime> Ngaysinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETAI> DETAIs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SINHVIEN> SINHVIENs { get; set; }
        public override string ToString()
        {
            return MaGV;
        }
    }
}
