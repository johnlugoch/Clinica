using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using Clinica.Models;


namespace Clinica.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Paciente> pacientes = new List<Paciente>();
            //string constr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            //using (MySqlConnection con = new MySqlConnection(constr))
            //{
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM paciente";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        pacientes.Add(new Paciente
                        {
                            id = Convert.ToInt32(sdr["identificacion"]),
                            pnombre = sdr["pnombre"].ToString(),
                            papellido = sdr["papellido"].ToString()
                        });
                    }
                }
                con.Close();
            }
            //}

            return View(pacientes);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}