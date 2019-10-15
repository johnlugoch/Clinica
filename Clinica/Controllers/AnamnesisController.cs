using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinica.Models;
using Clinica.Services;

namespace Clinica.Controllers
{
    public class AnamnesisController : Controller
    {
        // GET: Anamnesis
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GuardarAnamnesis(string idpaciente, string motivo_consulta, string enfermedad_actual, string organos, string obs_organos,
                          string sist_cardio, string obs_cardio, string sist_respi, string obs_respi, string digestivo, string obs_digestivo,
                          string sist_genito, string obs_sist_genito, string sist_endocrino, string obs_endocrino, string sist_hemato, string obs_hemato,
                          string sist_musculoesq, string obs_sist_musculoesq, string sist_nervioso, string obs_nervioso, string estado_mental, string obs_mental,
                          string sist_tegumentario, string obs_tegu)
        {

            int result = 0;            
            Anamnesis a = new Anamnesis();
            a.id_paciente = idpaciente;
            a.motivo_consulta = motivo_consulta;
            a.enfermedad_actual = enfermedad_actual;
            a.organos = organos;
            a.obs_organos = obs_organos;
            a.sist_cardio = sist_cardio;
            a.obs_cardio = obs_cardio;
            a.sist_respi = sist_respi;
            a.obs_respi = obs_respi;
            a.digestivo = digestivo;
            a.obs_digestivo = obs_digestivo;
            a.sist_genito = sist_genito;
            a.obs_genito = obs_sist_genito;
            a.sist_endocrino = sist_endocrino;
            a.obs_endocrino = obs_endocrino;
            a.sist_hemato = sist_hemato;
            a.obs_hemato = obs_hemato;
            a.sist_musculoesq = sist_musculoesq;
            a.obs_musculoesq = obs_sist_musculoesq;
            a.sist_nervioso = sist_nervioso;
            a.obs_nervioso = obs_nervioso;
            a.estado_mental = estado_mental;
            a.obs_mental = obs_mental;
            a.sist_tegumentario = sist_tegumentario;
            a.tegu = obs_tegu;
            Servicio s = new Servicio();
            result = s.SaveAnamensis(a);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}