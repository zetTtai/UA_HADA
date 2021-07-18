using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;


namespace usuWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Buscar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid && lista.SelectedValue != null && lista.SelectedValue != "Precio" && DireccionBusqueda.Text != "" && LocalidadBusqueda.Text != "")
            {
                //List<ENVivienda> viviendas;
                ENVivienda en = new ENVivienda();
                ENReforma re = new ENReforma();
                ENCategoria ca = new ENCategoria();
                en.direccionVivienda = DireccionBusqueda.Text;
                en.localidadVivienda = LocalidadBusqueda.Text;
                en.precioVivienda = int.Parse(lista.SelectedValue);

                if (en.readVivienda())
                {
                    Direccion.Text = en.direccionVivienda;
                    Localidad.Text = en.localidadVivienda;
                    Precio.Text = en.precioVivienda.ToString();
                    MetrosCuadrados.Text = en.metrosCuadradosVivienda.ToString();
                    NumeroBaños.Text = en.numeroBañosVivienda.ToString();
                    NumeroHabitaciones.Text = en.numeroDormitoriosVivienda.ToString();
                    imagenesUrl.Text = en.imagenUrl;
                    maps.Text = en.maps;
                    Descripcion.Text = en.descripcionVivienda;
                    Categoria.Text = en.categoria;
                    re.nombre = en.reforma;
                    bool reOk = re.readReforma();
                    if (reOk)
                    {
                        Reforma.Text = re.nombre;
                    }
                    else
                    {
                        Reforma.Text = "No tiene reforma";
                    }
                    if (reOk)
                    {
                        DescripcionReforma.Text = re.descripcionReforma;
                    }
                    else
                    {
                        DescripcionReforma.Text = "No tiene reforma";
                    }

                }
                else
                {
                    salida.Text = "No se ha encontrado ninguna Vivienda con esas descripciones";
                    Direccion.Text = "";
                    Localidad.Text = "";
                    Precio.Text = "";
                    MetrosCuadrados.Text = "";
                    NumeroBaños.Text = "";
                    NumeroHabitaciones.Text = "";
                    imagenesUrl.Text = "";
                    maps.Text = "";
                    Descripcion.Text = "";
                }
                
            }
            else
            {
                salida.Text = "Es necesario introducir los datos correspondientes";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //Descripcion.Text = lista.SelectedValue;
        }

        protected void cita(object sender, EventArgs e)
        {
            ENCita en = new ENCita();
            //en.horaCita = 
            if (en.createCita())
            {

                Session["Hora"] = en.hora;
                Session["Dia"] = en.dia;
                Session["Mes"] = en.mes;
                Session["Año"] = en.año;
                Session["LugarCita"] = Direccion.Text;
                Response.Redirect("CitaPublicada.aspx");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                ENFavoritos fav = new ENFavoritos();
                fav.usuario = Session["Usuario"].ToString();
                fav.viviendaDire = DireccionBusqueda.Text;
                fav.viviendaLoca = LocalidadBusqueda.Text;
               // bool existeFav = fav.readfav();
                if (fav.existe())
                {
                    salida.Text = "Este anuncion ya se encuentra en sus favoritos";
                }
                else
                {
                    if (fav.createListaFav())
                    {

                        salida.Text = "Se ha añadido correctamente a favoritos";
                        //salida.Text = "No se ha encontrado ninguna Vivienda con esas descripciones";
                        Direccion.Text = "";
                        Localidad.Text = "";
                        Precio.Text = "";
                        MetrosCuadrados.Text = "";
                        NumeroBaños.Text = "";
                        NumeroHabitaciones.Text = "";
                        imagenesUrl.Text = "";
                        maps.Text = "";
                        Descripcion.Text = "";
                    }
                    else
                    {
                        salida.Text = "No se ha podido añadir a favoritos";
                    }

                }
               
            }
               
            
        }

        protected void saltarImagenes(object sender, EventArgs e)
        {
            if(imagenesUrl.Text != null)
            {
                Response.Write("<script> window.open('" + imagenesUrl.Text + "','_blank'); </script>");
                
            }
        }

        protected void saltarMaps(object sender, EventArgs e)
        {
            Response.Write("<script> window.open('" + maps.Text + "','_blank'); </script>");

        }
    }

}