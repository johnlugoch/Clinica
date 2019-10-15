using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Examen
    {
        //signos vitales
        public string id_paciente { get; set; }
        public string tension_sistolica { get; set; }
        public string tension_diastolica { get; set; }
        public string frec_cardiaca { get; set; }
        public string frec_respiratoria { get; set; }
        public string temp { get; set; }
        public string peso { get; set; }
        public string talla { get; set; }
        public string tension_media { get; set; } //cal
        public string imc { get; set; }//cal
        //Examen
        public string aspecto { get; set; }
        public string cabeza { get; set; }
        public string cuello { get; set; }
        public string torax { get; set; }
        public string pulmon { get; set; }
        public string exam_cardio { get; set; }
        public string abdomen { get; set; }
        public string genitales { get; set; }
        public string exa_musculo { get; set; }
        public string exa_neuro { get; set; }
        public string piel { get; set; }
        public string fanera { get; set; }

    }
}