//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIM()
        {
            this.SUATCHIEUx = new HashSet<SUATCHIEU>();
        }
    
        public int id { get; set; }
        public string MaPhim { get; set; }
        public string TenPhim { get; set; }
        public string TinhTrang { get; set; }
        public int ThoiLuong { get; set; }
        public int MaDoHot { get; set; }
    
        public virtual DOHOTPHIM DOHOTPHIM { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUATCHIEU> SUATCHIEUx { get; set; }
    }
}
