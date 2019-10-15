using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    class Conexion
    {
        public static string cn = "server=127.0.0.1;database=migra_rips;Uid=root;pwd=;";

        public static MySqlConnection obtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1;database=migra_rips;Uid=root;pwd=;");
            conectar.Open();
            return conectar;
        }

    }

}