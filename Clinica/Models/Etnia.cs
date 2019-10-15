using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Etnia
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Etnia()
        {

        }

        public Etnia(int _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
        }
    }
}