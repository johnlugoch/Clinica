using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Anamnesis
    {
        public int id { get; set; }
        public string id_paciente { get; set; }
        public string motivo_consulta { get; set; }
        public string enfermedad_actual { get; set; }
        public string organos { get; set; }
        public string obs_organos { get; set; }
        public string sist_cardio { get; set; }
        public string obs_cardio { get; set; }
        public string sist_respi { get; set; }
        public string obs_respi { get; set; }
        public string digestivo { get; set; }
        public string obs_digestivo { get; set; }
        public string sist_genito { get; set; }
        public string obs_genito { get; set; }
        public string sist_endocrino { get; set; }
        public string obs_endocrino { get; set; }
        public string sist_hemato { get; set; }
        public string obs_hemato { get; set; }
        public string sist_musculoesq { get; set; }
        public string obs_musculoesq { get; set; }
        public string sist_nervioso { get; set; }
        public string obs_nervioso { get; set; }
        public string estado_mental { get; set; }
        public string obs_mental { get; set; }
        public string sist_tegumentario { get; set; }
        public string tegu { get; set; }
    }
}