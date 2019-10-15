using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Admisiones
    {
        public string idAdmision { get; set; }
        public string historia { get; set; }
        public DateTime fechaAdm { get; set; }
        public string id_contrato { get; set; }
        public string id_programa { get; set; }
        public string acudi_nombre { get; set; }
        public string acudi_parentesco { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string responsable { get; set; }
        public string observaciones { get; set; }
    }
}