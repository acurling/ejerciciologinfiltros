using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EJERCICIOEXAMEN23.clases;

namespace EJERCICIOEXAMEN23
{
    public partial class tipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
            }
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM tipo"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            datagrid.DataSource = dt;
                            datagrid.DataBind();  // Refrescar los datos
                        }
                    }
                }
            }
        }

        public void alertas(String texto)
        {
            string message = texto;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            int resultado = clases.ClaseTipo.Agregar(tdescripcion.Text);

            if (resultado > 0)
            {
                alertas("Tipo ingresado ha sido ingresado con exito");
                tdescripcion.Text = string.Empty;
                LlenarGrid();
            }
            else
            {
                alertas("Error al ingresar tipo");

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int resultado = clases.ClaseTipo.Borrar(int.Parse(tcodigo.Text));

            if (resultado > 0)
            {
                alertas("Tipo ha sido modificado con exito");
                tcodigo.Text = string.Empty;
               
                LlenarGrid();
            }
            else
            {
                alertas("Error al borrar tipo");

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int resultado = clases.ClaseTipo.Modificar(int.Parse(tcodigo.Text), tdescripcion.Text);

            if (resultado > 0)
            {
                alertas("Tipo ha sido modificado con exito");
                tcodigo.Text = string.Empty;

                LlenarGrid();
            }
            else
            {
                alertas("Error al modificar tipo");

            }
        }
    }
}