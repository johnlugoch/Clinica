using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;
using Clinica.Models;
using Clinica.Services;

namespace Clinica.Controllers
{
    public class PacienteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: Paciente
        public ActionResult Paciente()
        {
            return View();
        }

        public JsonResult GuardarPaciente(int id,string tipodoc, string papellido, string sapellido, string pnombre, string snombre, string fechanac, string sexo, string direccion, string telefono, 
                                          string email, string municipio, string barrio, string zona, int educativo, int ocupacion, string etnia)
        { 
            int result = 0;       
            // string tipo,
            Paciente p = new Paciente();
            p.id = (id);
            p.tipodoc = tipodoc;
            p.papellido = papellido;
            p.sapellido = sapellido;
            p.pnombre = pnombre;
            p.snombre = snombre;
            //p.fechanac = Convert.ToDateTime(fechanac);
            p.fechanac = (fechanac);
            p.sexo = sexo;
            p.direccion = direccion;
            p.telefono = telefono;
            p.email = email;
            p.municipio = municipio;
            p.barrio = barrio;
            p.zona = zona;
            p.niveleducativo = educativo;
            p.ocupacion = ocupacion;
            p.etnia = etnia;
            Servicio s = new Servicio();
            result = s.SavePaciente(p);
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public ActionResult ListaPaciente()
        {            
            return View();
        }
        
        public JsonResult VerPaciente()
        {
            List<Paciente> lista = new List<Paciente>();
            Servicio s = new Servicio();
            lista = s.GetListaPaciente();            
            return Json(lista, JsonRequestBehavior.AllowGet);            
        }

        
        public JsonResult ObtenerPaciente(string cedula)
        {
            List<Paciente> lista = new List<Paciente>();            
            Servicio s = new Servicio();
            lista = s.ObtenerPaciente(cedula);
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult ObtenerPacienteId(string id)
        {
            List<Paciente> lista = new List<Paciente>();
            Servicio s = new Servicio();
            lista = s.ObtenerPaciente(id);
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetEtnia()
        {
            List<Etnia> listaEtnia = new List<Etnia>();            
            Servicio s = new Servicio();
            listaEtnia = s.GetEtnia();
            return Json(listaEtnia, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetTipoDocumento()
        {
            List<TipoDocumento> lista = new List<TipoDocumento>();
            Servicio s = new Servicio();
            lista = s.GetTipoDocumento();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetNivelEducativo()
        {
            List<Educativo> lista = new List<Educativo>();
            Servicio s = new Servicio();
            lista = s.GetEducativo();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetOcupacion()
        {
            List<Ocupacion> lista = new List<Ocupacion>();
            Servicio s = new Servicio();
            lista = s.GetOcupacion();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetSexo()
        {
            List<Sexo> lista = new List<Sexo>();
            Servicio s = new Servicio();
            lista = s.GetSexo();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetZona()
        {
            List<Zona> lista = new List<Zona>();
            Servicio s = new Servicio();
            lista = s.GetZona();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetMunicipio()
        {
            List<Municipio> lista = new List<Municipio>();
            Servicio s = new Servicio();
            lista = s.GetMunicipio();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }



        public JsonResult GetData()
        {
            List<Etnia> lista = new List<Etnia>();
            lista.Add(new Etnia(1, "MESTIZO"));
            lista.Add(new Etnia(2, "RAIZAL"));
            lista.Add(new Etnia(3, "INDIGENA"));
            return Json(lista, JsonRequestBehavior.AllowGet);         
        }

    }
}