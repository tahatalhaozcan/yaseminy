//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace hastabakim
{
    using System;
    using System.Collections.Generic;
    
    public partial class hasta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hasta()
        {
            this.bakim = new HashSet<bakim>();
        }
    
        public int hastaID { get; set; }
        public string hastaAd { get; set; }
        public string hastaSoyad { get; set; }
        public string hastaGelisNedeni { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bakim> bakim { get; set; }
    }
}
