using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Services
{
    public class Sexo
    {
        public string id { get; set; }
        public string nombre { get; set; }

        public Sexo()
        {

        }

        public Sexo(string _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
        }
    }
}