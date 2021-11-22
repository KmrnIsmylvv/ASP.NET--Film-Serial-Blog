using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmBlog
{
    public partial class Haqqimda : System.Web.UI.Page
    {
        SerialFilm_CommentASPEntities db = new SerialFilm_CommentASPEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TBLHAQQIMIZDAs.ToList();
            Repeater1.DataBind();
        }
    }
}