//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmBlog
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLNOV
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLNOV()
        {
            this.TBL_BLOG = new HashSet<TBL_BLOG>();
        }
    
        public byte NovId { get; set; }
        public string NovAd { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_BLOG> TBL_BLOG { get; set; }
    }
}
