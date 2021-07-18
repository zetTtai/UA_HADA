<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MisAnuncios.aspx.cs" Inherits="usuWeb.MisAnuncios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos2.css" rel="stylesheet" />
    <style type="text/css">
         /*Botón genérico*/
        .boton {
            text-decoration: none;
            padding: 10px;
            font-weight: 600;
            font-size: 20px;
            color: #ffffff;
            background-color: #CC0000;
            border-radius: 6px;
            border: 2px solid #000;
            cursor: pointer;
            margin-left: 0px;
        }

        .boton:hover {
            color: #ffffff;
            background-color: #ff0000;
        }
        .auto-style3 {
            width: 1006px;
        }
        .auto-style5 {
            width: 1003px;
        }
        .auto-style6 {
            width: 1050px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DivCentroAnuncios">
        <div>
        <p style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 40px; font-weight: bold; text-decoration: none; color: #CC0000; font-style: italic; font-variant: normal; text-transform: none; width: 1008px;">
            Lista de Anuncios Publicados</p>
        </div>
    <asp:Label ID="salida" runat="server" Text=" " ForeColor ="Red"></asp:Label>
         <p class="auto-style6">
             &nbsp;<asp:Button ID="Button2" runat="server" Text="Primer Anuncio" Width="273px" Height="55px" OnClick="mostrarAnuncios" CssClass="boton" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Siguiente" runat="server" Text="Siguiente Anuncio" Width="263px" Height="55px" OnClick="Siguiente_Click" CssClass="boton"/>
        </p>
        <p>
            &nbsp;</p>
        <div style="font-family: 'gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; font-weight: bold; height: 924px;">
                <p class="auto-style3"> Dirección: <asp:TextBox ID="Direccion" runat="server" Height="25px" Width="250px"></asp:TextBox>
                    &nbsp;&nbsp; Localidad: <asp:TextBox ID="Localidad" runat="server" Width="200px"></asp:TextBox>
                    &nbsp;Precio:&nbsp;&nbsp;<asp:TextBox ID="Precio" runat="server" Width="175px" CssClass="auto-style1"></asp:TextBox>
                    &nbsp;</p>
                <p> Categoría: <asp:TextBox ID="Categoria" runat="server" Width="250px" CssClass="auto-style4"></asp:TextBox>
                </p>
                <p class="auto-style5">Metros Cuadrados: <asp:TextBox ID="MetrosCuadrados" runat="server" Width="80px" CssClass="auto-style2"></asp:TextBox>
                &nbsp;&nbsp;&nbsp; Número de habitaciones:&nbsp; <asp:TextBox ID="NumeroHabitaciones" runat="server" Width="80px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Número de baños:&nbsp; <asp:TextBox ID="NumeroBaños" runat="server" Width="80"></asp:TextBox>
                </p>
                <p>Reforma: <asp:TextBox ID="Reforma" runat="server" Width="525px" CssClass="auto-style6"></asp:TextBox>
                </p>
                <p>Descripción de la reforma:</p><asp:TextBox ID="DescripcionReforma" runat="server" Height="215px" Width="490px"></asp:TextBox>
                <br />
                <p>Descripción de la vivienda:</p><asp:TextBox ID="Descripcion" runat="server" Height="215px" Width="483px"></asp:TextBox>
                <br />
                <p >Enlace a Drive con imágenes: <asp:TextBox ID="imagenesUrl" runat="server"></asp:TextBox>
                </p>
                <p>Google Maps:
                <asp:TextBox ID="maps" runat="server"></asp:TextBox>
                </p>
                <br />
                <br />
            </div>


</div>
</asp:Content>
    