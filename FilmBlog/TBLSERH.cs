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
    
    public partial class TBLSERH
    {
        public int SerhId { get; set; }
        public string IstifadeciAd { get; set; }
        public string Mail { get; set; }
        public string SerhMezmun { get; set; }
        public Nullable<int> SerhBlog { get; set; }
    
        public virtual TBL_BLOG TBL_BLOG { get; set; }
    }
}