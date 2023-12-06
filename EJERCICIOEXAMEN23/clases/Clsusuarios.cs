using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace EJERCICIOEXAMEN23.clases
{
    public class Clsusuarios
    {
        // atributos
        private static int Id;
        private static string Correo;
        private static string Clave;
        private static string Nombre;
        public static int rol;
        public static string nombrerol;


        public int GetId()
        {
            return Id;
        }

        public static string GetCorreo()
        {
            return Correo;
        }

        public static string GetNombre()
        {
            return Nombre;
        }

        public void SetID(int id)
        {
            Id = id;
        }

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public void SetClave(string clave)
        {
            Clave = clave;
        }

        public void SetCorreo(string correo)
        {
            Correo = correo;
        }


        public static int ValidarLogin()
        {
            int retorno = 0;
            int tipo = 0;
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = Dbconn.obtenerConexionrestaurante())
                {
                    SqlCommand cmd = new SqlCommand("validarusuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("@correo", Correo));
                    cmd.Parameters.Add(new SqlParameter("@clave", Clave));

                    retorno = cmd.ExecuteNonQuery();
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())  // lea los datos usuario
                        {
                            retorno = 1;
                            Nombre = rdr.GetString(2);
                            rol = rdr.GetInt32(3);
                            nombrerol = rdr.GetString(4);

                        }
                        else
                        {
                            retorno = -1;
                        }

                    }


                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
                Conn.Dispose();
            }

            return retorno;
        }
    }
}