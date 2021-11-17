using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmBlog
{
    public partial class BlogDetal : System.Web.UI.Page
    {
        SerialFilm_CommentASPEntities db = new SerialFilm_CommentASPEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BlogId"]);
            var blog = db.TBL_BLOG.Where(x => x.BlogId == id).ToList();
            Repeater1.DataSource = blog;
            Repeater1.DataBind();
        }
    }
}