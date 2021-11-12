using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmBlog
{
    public partial class Default : System.Web.UI.Page
    {
        SerialFilm_CommentASPEntities db = new SerialFilm_CommentASPEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            var bloglar = db.TBL_BLOG.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();
        }
    }
}