//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLDeThi
{
    using System;
    using System.Collections.Generic;
    
    public partial class CoSo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoSo()
        {
            this.Khoas = new HashSet<Khoa>();
            this.rowguid = Guid.NewGuid();
        }
    
        public string MACS { get; set; }
        public string TENCS { get; set; }
        public string DIACHI { get; set; }
        public System.Guid rowguid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Khoa> Khoas { get; set; }
    }
}
