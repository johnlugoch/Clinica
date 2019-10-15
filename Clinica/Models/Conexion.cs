using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using MySql.Data.MySqlClient;
using Clinica.Models;

namespace Clinica.Models
{
    public class Conexion
    {
        public static MySqlConnection obtenerConexion()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Open();
            return con;
        }

        public static void cerrarConexion()
        {
            string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            MySqlConnection con = new MySqlConnection(constr);
            con.Close();            
        }
    }
}