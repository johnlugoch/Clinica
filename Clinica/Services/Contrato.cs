using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Services
{
    public class Contrato
    {
        public string id { get; set; }
        public string contrato { get; set; }

        public Contrato()
        {

        }

        public Contrato(string _id, string _contrato)
        {
            id = _id;
            contrato = _contrato;
        }
    }
}