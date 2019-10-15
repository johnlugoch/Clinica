using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Services
{
    public class Programa
    {
        public string id { get; set; }
        public string programa { get; set; }

        public Programa()
        {

        }

        public Programa (string _id, string _programa)
        {
            id = _id;
            programa = _programa;
        }
    }
}