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
    
    public partial class TBL_BLOG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_BLOG()
        {
            this.TBLSERHs = new HashSet<TBLSERH>();
        }
    
        public int BlogId { get; set; }
        public string BlogBasliq { get; set; }
        public string BlogMezmun { get; set; }
        public Nullable<System.DateTime> BlogTarix { get; set; }
        public string BlogSekil { get; set; }
        public Nullable<byte> BlogNov { get; set; }
        public Nullable<byte> BlogKateqoriya { get; set; }
    
        public virtual TBLKATEQORIYA TBLKATEQORIYA { get; set; }
        public virtual TBLNOV TBLNOV { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLSERH> TBLSERHs { get; set; }
    }
}