using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clinica.Models;
using Clinica.Services;

namespace Clinica.Controllers
{
    public class AdmisionesController : Controller
    {
        // GET: Admisiones
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GuardarAdmision(string historia, DateTime fechaadm, string idcontrato,
            string idprograma, string acompa, string parentesco, string direccion, string telefono,
            string responsable, string observaciones)
        {
            int result = 0;
            Admisiones a = new Admisiones();
            a.historia = historia;
            a.fechaAdm = fechaadm;
            a.id_contrato = idcontrato;
            a.id_programa = idprograma;
            a.acudi_nombre = acompa;
            a.acudi_parentesco = parentesco;
            a.direccion = direccion;
            a.telefono = telefono;
            a.responsable = responsable;
            a.observaciones = observaciones;
            Servicio s = new Servicio();
            result = s.SaveAdmision(a);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetContrato()
        {
            List<Contrato> lista = new List<Contrato>();
            Servicio s = new Servicio();
            lista = s.GetContrato();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetPrograma()
        {
            List<Programa> lista = new List<Programa>();
            Servicio s = new Servicio();
            lista = s.GetPrograma();
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public ActionResult GuardarVenta(string Fecha, string modoPago, string IdCliente, string Total, List<DetalleVenta> ListadoDetalle)
        {
            List<Cups> lista = new List<Cups>();
            Servicio s = new Servicio();
            //lista = s.GetCups(Name);
            return Json(lista, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Autocomplete(string Name)
        {
            List<Cups> lista = new List<Cups>();
            Servicio s = new Servicio();
            lista = s.GetCups(Name);
            return Json(lista, JsonRequestBehavior.AllowGet);            
        }

    }
}