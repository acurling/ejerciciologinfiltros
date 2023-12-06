using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EJERCICIOEXAMEN23.clases;

namespace EJERCICIOEXAMEN23
{
    public partial class Consulta : System.Web.UI.Page
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
            string rol = Clsusuarios.nombrerol;
            int idtec = 3;
            string constr = ConfigurationManager.ConnectionStrings["tecnicos"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand("CONSULTAREPARACIONES", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("@ROl", rol));
                cmd.Parameters.Add(new SqlParameter("@IDTEC", idtec));

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
}


