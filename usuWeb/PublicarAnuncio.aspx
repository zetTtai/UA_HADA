<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PublicarAnuncio.aspx.cs" Inherits="usuWeb.PublicarAnuncio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilos2.css" rel="stylesheet" />
    <style type="text/css">
        /*Botón tipo click*/
        .press_button {
            padding: 15px 25px;
            font-size: 30px;
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


        .auto-style3 {
            width: 1365px;
        }
        .auto-style5 {
            width: 733px;
            margin-left: 600px;
        }

        .auto-style7 {
            width: 1374px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="DivCentro">

    <div style="height: 1207px">
       <p style="font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif; font-size: 40px; font-weight: bold; text-decoration: none; color: #CC0000; font-style: italic; font-variant: normal; text-transform: none; width: 1370px;">
           Publique su anuncio de forma totalmente GRATUITA</p>
        <p class="auto-style3">
        <asp:Label ID="Direccion1" runat="server" Text="Dirección:"  ToolTip="Introduzca la dirección de la vivienda" Font-Bold="True"></asp:Label> 
        &nbsp;<asp:TextBox ID="Direccion" runat="server" Height="21px" Width="266px" CssClass="auto-style2"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Direccion" ErrorMessage="RequiredFieldValidator" ForeColor="red">Direccion necesaria</asp:RequiredFieldValidator>
           
        &nbsp;&nbsp; <asp:Label ID="Localidad1" runat="server" Text="Localidad:"  ToolTip="Solo letras y espacios si es necesario" Font-Bold="True"></asp:Label> 
        &nbsp;<asp:TextBox ID="Localidad" runat="server" Width="221px" CssClass="auto-style1"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Localidad" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Localidad necesaria</asp:RequiredFieldValidator>
        &nbsp;</p>
        <p class="auto-style5"> 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="Localidad" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="^[a-zA-Z\s]+$">ERROR</asp:RegularExpressionValidator>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        
        <asp:Label ID="CategoriaInfo" runat="server" Text="Categoría:"  ToolTip="Introduzca una de las posibles categorías" Font-Bold="True"></asp:Label> 
        &nbsp;<asp:DropDownList ID="Categoria" runat="server"
                          
                            Width="261px" AutoPostBack="false" Height="23px" OnSelectedValueChanged="DropDownList1_SelectedValueChanged" CssClass="auto-style6">
                            <asp:ListItem Value="Categoría"> </asp:ListItem>
                            <asp:ListItem Value="Piso">Piso</asp:ListItem>
                            <asp:ListItem Value="Chalet">Chalet</asp:ListItem>
                            <asp:ListItem Value="Campo">Campo</asp:ListItem>
                            <asp:ListItem Value="Cueva">Cueva</asp:ListItem>
                            <asp:ListItem Value="Bungalow">Bungalow</asp:ListItem>
                            </asp:DropDownList>
        
        
        
        &nbsp;&nbsp;
        
        
        
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="Categoria" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Categoria necesaria</asp:RequiredFieldValidator>
        
        &nbsp;
                
        <asp:Label ID="Precio1" runat="server" Text="Precio:"  ToolTip="Entre 25.000€ y 1.000.000€, no pongan los puntos de separación" Font-Bold="True"></asp:Label> 
        &nbsp;<asp:TextBox ID="Precio" runat="server" Width="208px" CssClass="auto-style4"></asp:TextBox>
        
        <br />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Precio" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" MaximumValue="1000000" MinimumValue="25000" Type="Integer">ERROR</asp:RangeValidator>
        
        <br />
        <p class="auto-style7">
       <asp:Label ID="MetrosCuadrados1" runat="server" Text="Metros cuadrados:"  ToolTip="Entre 1 y 4 dígitos" Font-Bold="True"></asp:Label> 
        &nbsp;<asp:TextBox ID="MetrosCuadrados" runat="server" Width="79px"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="MetrosCuadrados" ErrorMessage="RequiredFieldValidator" ForeColor="red">Metros Cuadrados necesario</asp:RequiredFieldValidator>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="NumeroHabitaciones1" runat="server" Font-Bold="True" Text="Número de habitaciones:" ToolTip="Entre 1 y 2 dígitos"></asp:Label>
&nbsp;<asp:TextBox ID="NumeroHabitaciones" runat="server" Width="79px"></asp:TextBox>
        &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="NumeroHabitaciones" ErrorMessage="RequiredFieldValidator" ForeColor="red">Número de habitaciones necesario</asp:RequiredFieldValidator>
        </p>
        
        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="MetrosCuadrados" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="\d{1,4}">ERROR</asp:RegularExpressionValidator>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="NumeroHabitaciones" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="\d{1,2}">ERROR</asp:RegularExpressionValidator>
        
        <br />
        
        <br />
        
        <asp:Label ID="NuemeroBaños1" runat="server" Text="Número de baños:"  ToolTip="Entre 1 y 2 dígitos" Font-Bold="True"></asp:Label> 
        &nbsp;<asp:TextBox ID="NumeroBaños" runat="server" Width="79"></asp:TextBox>
         &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="NumeroBaños" ErrorMessage="RequiredFieldValidator" ForeColor="red">Número de baños necesario</asp:RequiredFieldValidator>
                
        <br />
        
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="NumeroBaños" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="\d{1,2}">ERROR</asp:RegularExpressionValidator>
        
        <br />
        
         <br />
        
         <asp:Label ID="NombreReforma" runat="server" Text="Nombre de la reforma:"  ToolTip="Solo letras y espacios si es necesario" Font-Bold="True"></asp:Label> 
        &nbsp;<asp:TextBox ID="Reforma" runat="server" Width="242px"></asp:TextBox>
        <br />
        <br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="Reforma" ErrorMessage="ERROR" Font-Names="Gill Sans Nova" Font-Size="Small" ForeColor="Red" ValidationExpression="^[a-zA-Z\s]+$">ERROR</asp:RegularExpressionValidator>
         <br />
        <br />
         <asp:Label ID="DescripcionReforma1" runat="server" Text="Descripción de la reforma:"  ToolTip="Escriba lo que deseé de la reforma" Font-Bold="True"></asp:Label> 
        <br />
        <br />
        <asp:TextBox ID="DescripcionReforma" runat="server" Height="215px" Width="605px"></asp:TextBox>
         <br />
        <br />
         <asp:Label ID="DescripcionVivineda" runat="server" Text="Descripción de la vivienda:"  ToolTip="Escriba lo que deseé de la vivienda" Font-Bold="True"></asp:Label> 
        <br />
        <br />
        <asp:TextBox ID="Descripcion" runat="server" Height="215px" Width="605px"></asp:TextBox>

        <br />
        <br />

        <asp:Label ID="LinkDrive" runat="server" Text="Enlace a Drive con Imágenes:"  ToolTip="Introduzca el link para ver las imágenes" Font-Bold="True"></asp:Label>        
        &nbsp;<asp:TextBox ID="imagenesUrl" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="GoogleMaps" runat="server" Text="Google Maps:"  ToolTip="Introduzca la dirección de la vivienda de google maps" Font-Bold="True"></asp:Label>
        &nbsp;<asp:TextBox ID="maps" runat="server"></asp:TextBox>
        <asp:Label ID="Salida" runat="server" ForeColor="Red" Text=" "></asp:Label> 
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="publicar" runat="server" Text="Publicar" OnClick="publicar_Click" CssClass="press_button" Height="83px" Width="226px"/>
    </div>
        
    </div>
</asp:Content>
