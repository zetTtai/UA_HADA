<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="usuWeb.WebForm1" %>
        <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
            <link href="Estilos2.css" rel="stylesheet" />
            <style type="text/css">
                /*Botón para concertar citas*/
                .boton_citas{
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
                /*Botón tipo click*/
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

                /*Botón de favoritos*/
                .fave {
                    background: url('/imagenes/twitter_fave.png') no-repeat 0 2px;
                    cursor: pointer;
                    -webkit-animation: fave 1s steps(55);
                    animation: fave 1s steps(55)
                }
                .fave:hover, .fave.active {
                    background-position: -3519px 2px;
                    -webkit-transition: background 1s steps(55);
                    transition: background 1s steps(55)
                }

                @-webkit-keyframes fave {
                    0% {
                        background-position: 0 2px
                    }

                    100% {
                        background-position: -3519px 2px
                    }
                }

                @keyframes fave {
                    0% {
                        background-position: 0 2px
                    }

                    100% {
                        background-position: -3519px 2px
                    }
                }

                .fave.heart {
                    width: 58px;
                    height: 50px;
                    background:url(/images/posts/steps/heart.png) no-repeat;
                    background-size: auto 55px;
                    -webkit-animation: fave-heart 1s steps(28);
                    animation: fave-heart 1s steps(28)
                }

                    .fave.heart:hover, .fave.heart.active {
                        background-position: -1540px 0;
                        -webkit-transition: background 1s steps(28);
                        transition: background 1s steps(28)
                    }

                @-webkit-keyframes fave-heart {
                    0% {
                        background-position: 0 0
                    }

                    100% {
                        background-position: -1540px 0
                    }
                }

                @keyframes fave-heart {
                    0% {
                        background-position: 0 0
                    }

                    100% {
                        background-position: -1540px 0
                    }
                }

                .auto-style2 {
                    width: 959px;
                }

                .auto-style3 {
                    margin-left: 400px;
                }

                .auto-style7 {
                    width: 963px;
                }

                .auto-style9 {
                    width: 939px;
                }
            </style>
        </asp:Content>
        <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="DivCentroBuscar">
        <p style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 40px; font-weight: bold; text-decoration: none; color: #CC0000; font-style: italic; font-variant: normal; text-transform: none;">
            Búsqueda</p>
         <div style="font-family: 'gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 20px; font-weight: bold; height: 1217px;">
        <p class="auto-style2">Dirección: <asp:TextBox ID="DireccionBusqueda" runat="server" CssClass="auto-style1" Width="250px"></asp:TextBox>&nbsp; Localidad: <asp:TextBox ID="LocalidadBusqueda" runat="server" CssClass="auto-style5" Width="200px"></asp:TextBox>&nbsp; Precio:&nbsp;&nbsp;<asp:DropDownList ID="lista" runat="server"           
                            Width="175px" AutoPostBack="false" Height="23px" OnSelectedValueChanged="DropDownList1_SelectedValueChanged" CssClass="auto-style4">
                            <asp:ListItem Value="Precio"> </asp:ListItem>
                            <asp:ListItem Value="250000">50.000€ - 250.000€</asp:ListItem>
                            <asp:ListItem Value="500000">250.000€ - 500.000€</asp:ListItem>
                            <asp:ListItem Value="1000000">500.000€ - 1.000.000€</asp:ListItem>
                            </asp:DropDownList>
            &nbsp;&nbsp;
            </p> 
            <p class="auto-style3">
                <asp:Button ID="Buscar" runat="server" Text="Buscar" Width="140px" OnClick="Buscar_Click" CssClass="press_button"/>
                <p> Resultado:<asp:Label ID="salida" runat="server" Text="" ForeColor="Red"></asp:Label> </p>
             <p> Añadir a favoritos:&nbsp;
                <asp:Button ID="Button3" runat="server" OnClick="saltarMaps" Width="51px" Height="44px" CssClass="fave demo-container tap-to-activate" BackColor="Window" BorderStyle="NotSet" BorderWidth="0"/>
                </p>
           <div>
                <p class="auto-style7"> Direccion: <asp:TextBox ID="Direccion" runat="server" Height="30px" Width="250px"></asp:TextBox>
                &nbsp; Localidad: <asp:TextBox ID="Localidad" runat="server" Width="200px"></asp:TextBox>
                    &nbsp; Precio:<asp:TextBox ID="Precio" runat="server" Width="175px" CssClass="auto-style6"></asp:TextBox>
                </p>
                <p> Categoría: <asp:TextBox ID="Categoria" runat="server" Width="250px" CssClass="auto-style8"></asp:TextBox>
                </p>
                <p class="auto-style9">Metros cuadrados: <asp:TextBox ID="MetrosCuadrados" runat="server" Width="80px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp; Número de habitaciones: <asp:TextBox ID="NumeroHabitaciones" runat="server" Width="80px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Número de baños:&nbsp; <asp:TextBox ID="NumeroBaños" runat="server" Width="80px"></asp:TextBox>
                </p>
                <p>Reforma: <asp:TextBox ID="Reforma" runat="server" Width="516px" CssClass="auto-style10"></asp:TextBox>
                </p>
                <p>DescDescripción de la reforma:</p><asp:TextBox ID="DescripcionReforma" runat="server" Height="215px" Width="605px"></asp:TextBox>
                <p>Descripción de la vivienda:</p><asp:TextBox ID="Descripcion" runat="server" Height="215px" Width="483px"></asp:TextBox>
                <p>Link a Drive con Imagenes: <asp:TextBox ID="imagenesUrl" runat="server"></asp:TextBox>
                &nbsp;<asp:Button ID="Button5" runat="server" OnClick="saltarImagenes" Text="Ir a ..." CssClass="auto-style11" Height="25px" />
                </p>
                <p>Google Maps: <asp:TextBox ID="maps" runat="server"></asp:TextBox>
                &nbsp;<asp:Button ID="Button4" runat="server" OnClick="saltarImagenes" Text="Ir a ..." Height="25px"/>
                </p>
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" OnClick="cita" Text="Concertar cita" CssClass="boton_citas" Width="240px"/>
                
               </div>
            </div>
            </div>
         
</asp:Content>
