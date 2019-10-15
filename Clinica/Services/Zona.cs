using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Services
{
    public class Zona
    {
        public string id { get; set; }
        public string nombre { get; set; }

        public Zona()
        {

        }

        public Zona(string _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
        }
    }
}