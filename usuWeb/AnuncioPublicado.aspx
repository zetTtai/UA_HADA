<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AnuncioPublicado.aspx.cs" Inherits="usuWeb.AnuncioPublicado" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
    #grad1 {
      height: 80px;
      background-color: red; /* For browsers that do not support gradients */
      background-image: linear-gradient(to bottom right, green, yellow); /* Standard syntax (must be last) */
    }
    </style>
    <div class="DivCentro">
    <div id="grad1" style="text-align:center;
    margin-left: 150px;
    margin-top: 25px;
    margin-right: 150px;
    color:#f3f3f3; font-size:30px; font-weight:500; padding-top:50px; padding-bottom:50">
        Su anuncio ha sido publicado correctamtente.</div>
    </div>
</asp:Content>
