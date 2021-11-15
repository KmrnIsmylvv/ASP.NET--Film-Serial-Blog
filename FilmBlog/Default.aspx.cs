﻿using System;
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

            var bloglar2 = db.TBLKATEQORIYAs.ToList();
            Repeater2.DataSource = bloglar2;
            Repeater2.DataBind();

            var bloglar3 = db.TBL_BLOG.ToList();
            Repeater3.DataSource = bloglar3;
            Repeater3.DataBind();
        }
    }
}