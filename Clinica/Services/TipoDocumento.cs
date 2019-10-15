using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Services
{
    public class TipoDocumento
    {
        public string id { get; set; }
        public string nombre { get; set; }

        public TipoDocumento()
        {

        }

        public TipoDocumento(string _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
        }
    }
}