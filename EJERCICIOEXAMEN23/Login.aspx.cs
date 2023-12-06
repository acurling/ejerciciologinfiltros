using EJERCICIOEXAMEN23.clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EJERCICIOEXAMEN23
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bagregar_Click(object sender, EventArgs e)
        {
            clases.Clsusuarios objusuario = new clases.Clsusuarios();
            objusuario.SetCorreo(tcorreo.Text);
            objusuario.SetClave(tclave.Text);
            if (Clsusuarios.ValidarLogin() > 0)
            {
                Response.Redirect("consulta.aspx");
            }
        }
    }
}