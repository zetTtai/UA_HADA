using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using library;

namespace usuWeb
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Create(object sender, EventArgs e)
        {

            if (Page.IsValid)
            {
                ENUsuario en = new ENUsuario();
                en.nombre = NombreRegistro.Text;
                en.nif = NifRegistro.Text;
                en.telefono = NumTelefonoRe.Text;
                en.email = correo.Text;
                en.contraseña = contraseña.Text;
                if (en.createUsuario())
                {
                    Session["Usuario"] = NifRegistro.Text;
                    Session["Email"] = correo.Text;
                    Session["Telefono"] = NumTelefonoRe.Text;
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    Salida.Text = "Error no se pudo crear el usuario";
                }
            }
        }
    }
}