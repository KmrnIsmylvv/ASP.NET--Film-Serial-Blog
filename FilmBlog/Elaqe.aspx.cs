using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FilmBlog
{
    public partial class Elaqe : System.Web.UI.Page
    {
        SerialFilm_CommentASPEntities db = new SerialFilm_CommentASPEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLELAQE t = new TBLELAQE();
            t.AdSoyad = TextBox1.Text;
            t.Basliq = TextBox2.Text;
            t.Mail = TextBox3.Text;
            t.Mesaj = TextBox4.Text;
            db.TBLELAQEs.Add(t);
            db.SaveChanges();
        }
    }
}