using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Antecedentes
    {
        public int id { get; set; }
        public string id_paciente { get; set; }
        public string ant_hipert { get; set; }
        public string obs_ant_hipert { get; set; }
        public string cardiopatia { get; set; }
        public string obs_cardiopatia { get; set; }
        public string infarto_miocardio { get; set; }
        public string obs_infarto { get; set; }
        public string otrapato { get; set; }
        public string obs_otrapato { get; set; }
        public string ant_cirugia { get; set; }
        public string obs_ant_cirugia { get; set; }
        public string traumatico { get; set; }
        public string obs_traumatico { get; set; }
        public string toxico { get; set; }
        public string obs_toxico { get; set; }
        public string transfusion { get; set; }
        public string obs_transfusion { get; set; }
        public string hospitalario { get; set; }
        public string obs_hospitalario { get; set; }
        public string alergicos { get; set; }
        public string obs_alergicos { get; set; }
        public string gineco { get; set; }
        public string obs_gineco { get; set; }
        public string familiares { get; set; }
        public string tabaquismo { get; set; }
        public string conducta_alimento { get; set; }
        public string estres { get; set; }
        public string otro { get; set; }

    }
}