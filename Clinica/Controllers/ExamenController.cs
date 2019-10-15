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
    public class ExamenController : Controller
    {
        // GET: Examen
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GuardarExamen(string idpaciente, string tension_art_sist, string tension_art_dist, 
            string frec_cardiaca, string frec_respiratoria, string temperatura, string peso, string talla,
            string tension, string imc, string aspecto, string cabeza, string cuello, string torax, string pulmon,
            string exam_cardiovas, string abdomnen, string genitales, string musculo, string neurologico, string piel,
            string fanera)
        {
            int result = 0;
            Examen e = new Examen();
            e.id_paciente = idpaciente;
            e.tension_sistolica = tension_art_sist;
            e.tension_diastolica = tension_art_dist;
            e.frec_cardiaca = frec_cardiaca;
            e.frec_respiratoria = frec_respiratoria;
            e.temp = temperatura;
            e.peso = peso;
            e.talla = talla;
            e.tension_media = tension;
            e.imc = imc;
            e.aspecto = aspecto;
            e.cabeza = cabeza;
            e.cuello = cuello;
            e.torax = torax;
            e.pulmon = pulmon;
            e.exam_cardio = exam_cardiovas;
            e.abdomen = abdomnen;
            e.genitales = genitales;
            e.exa_musculo = musculo;
            e.exa_neuro = neurologico;
            e.piel = piel;
            e.fanera = fanera;
            Servicio s = new Servicio();
            result= s.SaveExamen(e);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}