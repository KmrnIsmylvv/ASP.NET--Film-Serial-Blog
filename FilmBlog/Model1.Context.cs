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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SerialFilm_CommentASPEntities : DbContext
    {
        public SerialFilm_CommentASPEntities()
            : base("name=SerialFilm_CommentASPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_BLOG> TBL_BLOG { get; set; }
        public virtual DbSet<TBLELAQE> TBLELAQEs { get; set; }
        public virtual DbSet<TBLHAQQIMIZDA> TBLHAQQIMIZDAs { get; set; }
        public virtual DbSet<TBLKATEQORIYA> TBLKATEQORIYAs { get; set; }
        public virtual DbSet<TBLNOV> TBLNOVs { get; set; }
        public virtual DbSet<TBLSERH> TBLSERHs { get; set; }
    }
}
