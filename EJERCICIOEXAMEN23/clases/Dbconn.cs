using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EJERCICIOEXAMEN23.clases
{
    public class Dbconn
    {

        public static SqlConnection obtenerConexion()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            return conexion;
        }

        public static SqlConnection obtenerConexiontecnicos()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["tecnicos"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            return conexion;
        }

        public static SqlConnection obtenerConexionrestaurante()
        {
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["restaurante"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            return conexion;
        }
    }
}