using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Services
{
    public class Cups
    {
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string valor_soat { get; set; }
        public string valor_iss { get; set; }

        public Cups()
        {

        }

        public Cups(string _codigo, string _nombre, string _valor_soat, string _valor_iss)
        {
            codigo = _codigo;
            nombre = _nombre;
            valor_soat = _valor_soat;
            valor_iss = _valor_iss;
        }
    }
}