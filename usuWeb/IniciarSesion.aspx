<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="usuWeb.IniciarSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos.css" rel="stylesheet" />
        <style>
     .press_button {
        padding: 15px 25px;
        font-size: 24px;
        text-align: center;
        cursor: pointer;
        outline: none;
        color: #fff;
        background-color: #e80000;
        border: none;
        border-radius: 15px;
        box-shadow: 0 9px #999;
     }
    .press_button:hover {
        background-color: #c80000
    }
    .press_button:active {
        background-color: #c80000;
        box-shadow: 0 5px #666;
        transform: translateY(4px);
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DivCentroInicio">
        <div>
        <p style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 40px; font-weight: bold; text-decoration: none; color: #CC0000; font-style: italic; font-variant: normal; text-transform: none;">
            Inicio de sesión</p>
    </div>
    <p style="font-family: 'gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; font-weight: bold; height: 20px;"> Correo electrónico:</p> <asp:TextBox ID="email" runat="server" Width="270px" CssClass="auto-style1"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" Correo no introducido" ControlToValidate="email" Text="Debe ingresar un correo electrónico" ForeColor="Red"></asp:RequiredFieldValidator>        
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="email" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator>

        <br />
    <p style="font-family: 'gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; font-weight: bold; height: 22px;"> Contraseña:</p> <asp:TextBox ID="contraseña" type="password"  runat="server" Width="270px" CssClass="auto-style2"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Contraseña no introducida" ControlToValidate="contraseña" ForeColor="Red"></asp:RequiredFieldValidator>  
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar Sesión" Width="296px" CssClass="press_button"/>
    </div>
</asp:Content>
