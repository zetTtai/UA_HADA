using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb
{
    public partial class MisAnuncios : System.Web.UI.Page
    {
        protected void mostrarAnuncios(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                ENReforma re = new ENReforma();
                ENVivienda en = new ENVivienda();
                en.dueño = Session["Usuario"].ToString();
                if (en.readUsuVivienda())
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
                    salida.Text = "No hay anuncios que mostrar";
                }
            }
            else
            {
                salida.Text = "No puede ver sus anuncions sin iniciar sesion";
            }
        }

        protected void Siguiente_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                if(Direccion.Text != "")
                {
                    ENVivienda en = new ENVivienda();
                    en.dueño = Session["Usuario"].ToString();
                    en.direccionVivienda = Direccion.Text;
                    en.localidadVivienda = Localidad.Text;
                    ENReforma re = new ENReforma();


                    if (en.readFollowingVivienda())
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
            }
            else
            {
                salida.Text = "No puede ver sus anuncions sin iniciar sesion";
            }
        }
    }
}