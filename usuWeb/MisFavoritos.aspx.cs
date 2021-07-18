using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb
{
    public partial class MisFavoritos : System.Web.UI.Page
    {
        protected void mostarFav(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                
                ENFavoritos fav = new ENFavoritos();
                ENReforma re = new ENReforma();
                fav.usuario = Session["Usuario"].ToString();
                if (fav.readfav())
                {
                    ENVivienda en = new ENVivienda();
                    en.dueño = Session["Usuario"].ToString();
                    en.localidadVivienda = fav.viviendaLoca;
                    en.direccionVivienda = fav.viviendaDire;
                    if (en.readFavVivienda())
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
                    
                }
                else
                {
                    salida.Text = "No hay anuncios que mostrar";
                }
            }
            else
            {
                salida.Text = "No puede ver sus anuncions sin iniciar sesion";
            }
        }

        protected void cita(object sender, EventArgs e)
        {
            if(Session["Usuario"] != null)
            {
                ENCita en = new ENCita();
                //en.horaCita = 
                en.usuario = Session["Usuario"].ToString();
                if (en.createCita() && Direccion.Text != "")
                {

                    Session["Hora"] = en.hora;
                    Session["Dia"] = en.dia;
                    Session["Mes"] = en.mes;
                    Session["Año"] = en.año;
                    Session["LugarCita"] = Direccion.Text;
                    Response.Redirect("CitaPublicada.aspx");
                }
                else
                {
                    salida.Text = "No puede concertar cita sin seleccionar una vivienda favorita";
                }
            }
            else
            {
                salida.Text = "No puede concertar citas sin iniciar sesion";
            }
            
        }

        protected void Siguiente_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                if(Direccion.Text != "")
                {
                    ENFavoritos fav = new ENFavoritos();
                    fav.usuario = Session["Usuario"].ToString();
                    fav.viviendaDire = Direccion.Text;
                    fav.viviendaLoca = Localidad.Text;

                    if (fav.nextFav())
                    {
                        ENVivienda en = new ENVivienda();
                        ENReforma re = new ENReforma();
                        en.dueño = Session["Usuario"].ToString();
                        en.direccionVivienda = fav.viviendaDire;
                        en.localidadVivienda = fav.viviendaLoca;

                        bool ok = en.readFavVivienda();

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
                        salida.Text = "No hay mas auncios que mostrar";
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
                    salida.Text = "No ha mostrado ningun favorito, no puede avanzar";
                }
                
            }
            else
            {
                salida.Text = "No puede ver sus anuncions sin iniciar sesion";
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}