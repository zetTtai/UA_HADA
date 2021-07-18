<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MisFavoritos.aspx.cs" Inherits="usuWeb.MisFavoritos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos2.css" rel="stylesheet" />
    <style type="text/css">
        /*Botón para concertar citas*/
        .boton_citas {
            text-decoration: none;
            padding: 10px;
            font-weight: 600;
            font-size: 20px;
            color: #ffffff;
            background-color: #5b5858;
            border-radius: 6px;
            border: 2px solid #524f4f;
            cursor: pointer;
        }

        .boton_citas:hover {
            color: #ffffff;
            background-color: #686464;
        }
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
        }

        .boton:hover {
            color: #ffffff;
            background-color: #ff0000;
        }
        .auto-style1 {
            width: 1035px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DivCentroFavoritos">
    <div>
        <p style=" font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 40px; font-weight: bold; text-decoration: none; color: #CC0000; font-style: italic; font-variant: normal; text-transform: none;">
            Lista de Viviendas Favoritas
        </p>
    </div>
    <asp:Label ID="salida" runat="server" Text=" " ForeColor ="Red"></asp:Label>
         <p class="auto-style1">
             &nbsp;<asp:Button ID="Button2" runat="server" Text="Mostrar  Favoritos" Width="240px" OnClick="mostarFav" CssClass="boton" Height="55px"/>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
             <asp:Button ID="Siguiente" runat="server" Text="Siguiente Anuncio Favorito" Width="393px" OnClick ="Siguiente_Click" CssClass="boton" Height="55px"/>
            </p>
        <div style="font-family: 'gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; font-weight: bold; height: 1059px;">
                <p> Dirección: <asp:TextBox ID="Direccion" runat="server" Height="25px" Width="250px"></asp:TextBox>
                    &nbsp;&nbsp; Localidad: <asp:TextBox ID="Localidad" runat="server" Width="200px"></asp:TextBox>
                    &nbsp;Precio:&nbsp;&nbsp;<asp:TextBox ID="Precio" runat="server" Width="175px"></asp:TextBox>
                    &nbsp;&nbsp;</p>

                &nbsp;<p> Categoría: <asp:TextBox ID="Categoria" runat="server" Width="250px" CssClass="auto-style1"></asp:TextBox>
                </p>&nbsp;<p>Metros cuadrados: <asp:TextBox ID="MetrosCuadrados" runat="server" Width="79px"></asp:TextBox>
                    &nbsp;&nbsp; Número de habitaciones:&nbsp;&nbsp; <asp:TextBox ID="NumeroHabitaciones" runat="server" Width="80px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Número de baños:&nbsp; <asp:TextBox ID="NumeroBaños" runat="server" Width="80px"></asp:TextBox>
                </p>
                <p>&nbsp;</p>
                <p>Reforma: <asp:TextBox ID="Reforma" runat="server" Width="525px"></asp:TextBox>
                </p>&nbsp;<p>Descripción de la reforma:</p><asp:TextBox ID="DescripcionReforma" runat="server" Height="215px" Width="490px"></asp:TextBox>
                &nbsp;<p>Descripción de la vivienda:</p><asp:TextBox ID="Descripcion" runat="server" Height="215px" Width="483px"></asp:TextBox>
                <br />
                <p>Link a Drive con Imagenes: <asp:TextBox ID="imagenesUrl" runat="server"></asp:TextBox>
                </p>
                <p>Google Maps: <asp:TextBox ID="maps" runat="server"></asp:TextBox>
                </p>
            
             <p>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Button ID="Button1" runat="server" OnClick="cita" Text="Concertar cita" Width="240px" CssClass="boton_citas"/>
            </p>
            </div>
    </div>
</asp:Content>
