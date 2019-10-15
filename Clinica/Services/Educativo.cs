using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Services
{
    public class Educativo
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public Educativo()
        {

        }

        public Educativo(int _id, string _nombre)
        {
            id = _id;
            nombre = _nombre;
        }
    }
}