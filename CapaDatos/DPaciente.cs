using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Entidad;


namespace CapaDatos
{
    public class DPaciente
    {
        private int _Id;
        private string _Nombre;
        private string _Apellido;

        MySqlConnection con = new MySqlConnection();

        public int id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public string nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        public string apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        //Constructor Vacío
        public DPaciente()
        {

        }

        //Constructor con parámetros
        public DPaciente(int idproducto, string nombre, string apellido)
        {
            this._Id = idproducto;
            this._Nombre = nombre;
            this._Apellido = apellido;            
        }

        public void insertar(EPaciente EntidadPaciente)
        {

            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO paciente (id,nombre,apellido) value (@param1,@param2,@param3)";
                cmd.Parameters.AddWithValue("@param1", EntidadPaciente.id);
                cmd.Parameters.AddWithValue("@param2", EntidadPaciente.nombre);
                cmd.Parameters.AddWithValue("@param3", EntidadPaciente.apellido);                
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

        }

        public DataTable Mostrar()
        {
            DataTable dtResultado = new DataTable("Pacientes");
            try
            {
                con.ConnectionString = Conexion.cn;
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM Paciente";
                MySqlDataAdapter sqlDat = new MySqlDataAdapter(cmd);
                sqlDat.Fill(dtResultado);
            }
            catch (Exception ex)
            {
                dtResultado = null;
            }
            return dtResultado;
        }
    }
}
