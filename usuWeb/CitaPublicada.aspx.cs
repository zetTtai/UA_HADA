using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb
{
    public partial class CitaPublicada : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                Salida.Text = "Su cita ha sido programada para el " + Session["Dia"].ToString() + "/" + Session["Mes"].ToString() + "/" + Session["Año"] + " en la siguiente direccion: " + Session["LugarCita"].ToString() + " a las " + Session["Hora"] + ":00";
                Salida2.Text = "El email del vendedor es: " + Session["Email"].ToString() + ", y su numero de telefono es el siguien:" + Session["Telefono"].ToString();
            }

        }
    }
}