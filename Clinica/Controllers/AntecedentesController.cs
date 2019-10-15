using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinica.Models;
using Clinica.Services;

namespace Clinica.Controllers
{
    public class AntecedentesController : Controller
    {
        // GET: Antecedentes
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Antecedentes()
        {
            return View();
        }

        public JsonResult GuardarAntecedentes(string idpaciente, string ant_hipert, string obs_ant_hipert, string cardiopatia,
            string obs_cardiopatia, string infarto_miocardio, string obs_infarto, string otrapato, string obs_otrapato,
            string ant_cirugia, string obs_ant_cirugia, string traumatico, string obs_traumatico, string toxico, string obs_toxico,
            string transfusion, string obs_transfusion, string hospitalario, string obs_hospitalario, string alergicos, 
            string obs_alergicos, string gineco, string obs_gineco, string familiares, string tabaquismo, string conducta_alimento,
            string estres, string otro)
        {
            int result = 0;
            Antecedentes a = new Antecedentes();
            a.id_paciente = idpaciente;
            a.ant_hipert = ant_hipert;
            a.obs_ant_hipert = obs_ant_hipert;
            a.cardiopatia = cardiopatia;
            a.obs_cardiopatia = obs_cardiopatia;
            a.infarto_miocardio = infarto_miocardio;
            a.obs_infarto = obs_infarto;
            a.otrapato = otrapato;
            a.obs_otrapato = obs_otrapato;
            a.ant_cirugia = ant_cirugia;
            a.obs_ant_cirugia = obs_ant_cirugia;
            a.traumatico = traumatico;
            a.obs_traumatico = obs_traumatico;
            a.toxico = toxico;
            a.obs_toxico = obs_toxico;
            a.transfusion = transfusion;
            a.obs_transfusion = obs_transfusion;
            a.hospitalario = hospitalario;
            a.obs_hospitalario = obs_hospitalario;
            a.alergicos = alergicos;
            a.obs_alergicos = obs_alergicos;
            a.gineco = gineco;
            a.obs_gineco = obs_gineco;
            a.familiares = familiares;
            a.tabaquismo = tabaquismo;
            a.conducta_alimento = conducta_alimento;
            a.estres = estres;
            a.otro = otro;
            Servicio s = new Servicio();
            result = s.SaveAntecedentes(a);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}