using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace EJERCICIOEXAMEN23.clases
{
    public class ClaseArticulo
    {
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public string fecha { get; set; }
        public float precio { get; set; }

        public ClaseArticulo(int codigo, string descripcion, string fecha, float precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.fecha = fecha;
            this.precio = precio;
        }
        public ClaseArticulo() { }

        public static int Agregar(int tipo, string texto, string fecha, float precio )
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Dbconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("AgregarArticulo", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", texto));
                    cmd.Parameters.Add(new SqlParameter("@TIPO", tipo));
                    cmd.Parameters.Add(new SqlParameter("@FECHA", fecha));
                    cmd.Parameters.Add(new SqlParameter("@PRECIO", precio));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;

        }
    }
}