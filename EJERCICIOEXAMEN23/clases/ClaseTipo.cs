using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace EJERCICIOEXAMEN23.clases
{
    public class ClaseTipo
    {
        public static int id { get; set; }
        public static string descripcion { get; set; }


        public ClaseTipo(int Id, string Descripcion)
        {
            id = Id;
            descripcion = Descripcion;
        }
        public ClaseTipo() { }


        public static int Agregar(string texto)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Dbconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("INGRESARTIPO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", texto));

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




        public static int Borrar(int cod)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Dbconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("BORRARTIPO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@CODIGO", cod));

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


        public static int Modificar(int cod, string texto)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Dbconn.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ACTUALIZARTIPO", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@CODIGO", cod));
                    cmd.Parameters.Add(new SqlParameter("@DESCRIPCION", texto));

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
