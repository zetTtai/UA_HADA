using library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usuWeb
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                ENUsuario en = new ENUsuario();
                en.email = email.Text;
                en.contraseña = contraseña.Text;
                if (en.readUsuario())
                {
                    Session["Usuario"] = en.nif;
                    Session["Email"] = en.email;
                    Session["Telefono"] = en.telefono;
                    Response.Redirect("Inicio.aspx");
                }
                else
                {
                    //Response.Redirect("ayuda.aspx");
                }
            }

        }
    }
}