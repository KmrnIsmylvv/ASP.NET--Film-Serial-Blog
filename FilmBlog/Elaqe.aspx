<%@ Page Title="" Language="C#" MasterPageFile="~/User/Istifadeci.Master" AutoEventWireup="true" CodeBehind="Elaqe.aspx.cs" Inherits="FilmBlog.Elaqe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="contact-content">
        <div class="container">
            <div class="contact-info">
                <h2>ƏLAQƏ</h2>
                <p>
                    Əgər sizin də bəyəndiyiniz hər hansı film və ya serial varsa və yaxud hər hansı bir şikayətiniz varsa  bizimlə əlaqə saxlaya bilərsiniz. 
                </p>
            </div>
            <div class="contact-details">
                <form runat="server">
                    <asp:TextBox ID="TextBox1" runat="server"  placeholder="Ad, Soyad" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server"  placeholder="E-Mail" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server"  placeholder="Telefon" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox4" runat="server"  placeholder="Başlıq" required=""></asp:TextBox>
                    <asp:TextBox ID="TextBox5" runat="server"  placeholder="Mesaj" required="" Height="100" TextMode="MultiLine"></asp:TextBox>

                    <asp:Button ID="Button1" runat="server" Text="Göndər" />
                </form>
            </div> 
            <div class="contact-details">
                <div class="col-md-6 contact-map">
                    <h4>MƏKAN</h4>
                    <div class="mapouter"><div class="gmap_canvas"><iframe width="600" height="500" id="gmap_canvas" src="https://maps.google.com/maps?q=Baku&t=&z=13&ie=UTF8&iwloc=&output=embed" frameborder="0" scrolling="no" marginheight="0" marginwidth="0"></iframe><a href="https://www.embedgooglemap.net/blog/divi-discount-code-elegant-themes-coupon/"></a><br><style>.mapouter{position:relative;text-align:right;height:500px;width:600px;}</style><a href="https://www.embedgooglemap.net">google maps html widget</a><style>.gmap_canvas {overflow:hidden;background:none!important;height:500px;width:600px;}</style></div></div>
                   </div>
               
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
</asp:Content>
