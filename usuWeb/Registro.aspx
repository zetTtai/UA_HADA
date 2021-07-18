<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="usuWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos2.css" rel="stylesheet" />
    <style type="text/css">
        .press_button {
        padding: 15px 25px;
        font-size: 35px;
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
    .auto-style1 {
        width: 1432px;
    }
    .auto-style5 {
        width: 1431px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DivCentroRegistro">
    <p style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 40px; font-weight: bold; text-decoration: none; color: #CC0000; font-style: italic; font-variant: normal; text-transform: none; width: 1493px;">
        REGISTRO</p>
        <div style="font-family: 'gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; font-weight: bold; height: 441px; margin-right: 0px;">
        <p class="auto-style1"><asp:Label ID="Nombre" runat="server" Text="Nombre:"  ToolTip="Letras con espacios si es necesario" Font-Bold="True"></asp:Label> &nbsp;<asp:TextBox ID="NombreRegistro" runat="server" Width="206px" ToolTip="Letras con espacios si es necesario" CssClass="auto-style3"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Nombre no introducido" ControlToValidate="NombreRegistro" Text="Debe introducir un nombre" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="CorreoE" runat="server" Text="Correo electrónico:"  ToolTip="Formato: aa@bb.cc" Font-Bold="True"></asp:Label> 
        &nbsp;<asp:TextBox ID="correo" runat="server" Width="260px" CssClass="auto-style2"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage=" Correo no introducido" ControlToValidate="correo" Text="Debe introducir un correo " ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="NombreRegistro" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="^[a-zA-Z\s]+$">ERROR</asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="correo" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="\S+@\S+\.\S+">ERROR</asp:RegularExpressionValidator>
            <br />
            <p class="auto-style5">
        <asp:Label ID="DNI" runat="server" Text="DNI/NIF:"  ToolTip="8 números o 8 números + la letra mayúscula" Font-Bold="True"></asp:Label>
        &nbsp;<asp:TextBox ID="NifRegistro" runat="server" Width="200px" CssClass="auto-style4"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Nif no introducido" ControlToValidate="NifRegistro" Text="Debe introducir un DNI/NIF" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Telefono" runat="server" Font-Bold="True" Text="Número de teléfono:" ToolTip="9 dígitos"></asp:Label>
&nbsp;<asp:TextBox ID="NumTelefonoRe" runat="server" Width="199px"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Telefono no introducido" ControlToValidate="NumTelefonoRe" Text="Debe introducir un número de teléfono" ForeColor="Red"></asp:RequiredFieldValidator>
                </p>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="NifRegistro" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="\d{8}[A-Z]|\d{8}">ERROR</asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="NumTelefonoRe" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="\d{9}">ERROR</asp:RegularExpressionValidator>

            <br />
            <p>
        <asp:Label ID="Contrasenya" runat="server" Text="Contraseña:"  ToolTip="Entre 8 y 16 caracteres" Font-Bold="True"></asp:Label> 
        &nbsp;</p>
            <p>
                <asp:TextBox ID="contraseña" type="password"  runat="server" Width="200px" OnTextChanged="contraseña_TextChanged"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Debe introducir una contraseña" ControlToValidate="contraseña" ForeColor="Red"></asp:RequiredFieldValidator>
            </p>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="contraseña" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="\w{8,16}">ERROR</asp:RegularExpressionValidator>
        <br />
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Contraseñas desiguales" ControlToCompare="contraseña" ControlToValidate="contraseña2" ForeColor="Red">Las contraseñas deben ser idénticas</asp:CompareValidator>
        <br />
        <asp:Label ID="Contrasenya2" runat="server" Text="Confirmar contraseña: "  ToolTip="Debe coincidir con la otra" Font-Bold="True"></asp:Label>
        <br />
        <asp:TextBox ID="contraseña2" type="password" runat="server" Width="200px" OnTextChanged="contraseña_TextChanged" Height="25px"></asp:TextBox>
        
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Contraseña2 no introducida" ControlToValidate="contraseña2" Text="Debe introducir una contraseña" ForeColor="Red"></asp:RequiredFieldValidator>
        &nbsp;
            <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="contraseña2" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="\w{8,16}">ERROR</asp:RegularExpressionValidator>
        <br />
        <br />
        </div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server"  Text="¡Regístrate!" Width="303px" OnClick="Create" CssClass="press_button" Height="87px" />
        <br />
        <asp:Label ID="Salida" runat="server"  Font-Bold="True"></asp:Label>
        <br />
        
        </div>
</asp:Content>