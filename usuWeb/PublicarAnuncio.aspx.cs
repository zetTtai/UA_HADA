using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb
{
    public partial class PublicarAnuncio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void publicar_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
            {
                Salida.Text = "Para poder publicar un anuncio debe estar registrado";
            }
            else
            {
                if (Page.IsValid)
                {
                    ENVivienda en = new ENVivienda();
                    ENReforma re = new ENReforma();
                    ENUsuario usu = new ENUsuario();
                    usu.nif = Session["Usuario"].ToString();
                    
                    re.nombre = Reforma.Text;
                    re.descripcionReforma = DescripcionReforma.Text;
                    bool reOk = re.createReforma();
                    en.reforma = Reforma.Text;
                    en.localidadVivienda = Localidad.Text;
                    en.direccionVivienda = Direccion.Text;
                    en.precioVivienda = int.Parse(Precio.Text);
                    en.descripcionVivienda = Descripcion.Text;
                    en.metrosCuadradosVivienda = int.Parse(MetrosCuadrados.Text);
                    en.numeroDormitoriosVivienda = int.Parse(NumeroHabitaciones.Text);
                    en.numeroBañosVivienda = int.Parse(NumeroBaños.Text);
                    en.imagenUrl = imagenesUrl.Text;
                    en.maps = maps.Text;
                    en.reforma = re.nombre;
                    en.dueño = Session["Usuario"].ToString();
                    en.categoria = Categoria.SelectedValue;
                    if (en.createVivienda() && reOk)
                    {
                        //en.reforma = re.nombre;
                        Response.Redirect("AnuncioPublicado.aspx");
                    }
                    else
                    {
                        Salida.Text = "Su anuncio  no ha sido publicado correctamente :(";
                    }
                }
            }
        }
    }
}