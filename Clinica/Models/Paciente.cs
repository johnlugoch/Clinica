using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Clinica.Models
{
    public class Paciente
    {
        public int id { get; set; }
        public string tipodoc { get; set; }
        public string papellido { get; set; }
        public string sapellido { get; set; }
        public string pnombre { get; set; }
        public string snombre{ get; set; }
        public string fechanac { get; set; }
        public string sexo { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string municipio { get; set; }
        public string barrio { get; set; }
        public string zona { get; set; }
        public int niveleducativo { get; set; }
        public int ocupacion { get; set; }
        public string etnia { get; set; }
        public string email { get; set; }
        
    }

}