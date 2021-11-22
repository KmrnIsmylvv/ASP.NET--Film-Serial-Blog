<%@ Page Title="" Language="C#" MasterPageFile="~/User/Istifadeci.Master" AutoEventWireup="true" CodeBehind="Haqqimda.aspx.cs" Inherits="FilmBlog.Haqqimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="about-section">
            <div class="about-grid">
                <h3>HAQQIMIZDA</h3>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <p><%# Eval("Aciqlama") %></p>

                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>



</asp:Content>
