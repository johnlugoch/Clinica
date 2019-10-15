using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using Clinica.Models;

namespace Clinica.Services
{
    public class Servicio
    {
        //guardar paciente
        public int SavePaciente(Paciente p)
        {
            int result = 0;
            MySqlConnection con = Conexion.obtenerConexion();
            MySqlCommand cmd = con.CreateCommand();
            //string query = "INSERT INTO paciente (identificacion,tipodoc,papellido,sapellido,pnombre,snombre,fechanac,sexo) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)";
            string query = "INSERT INTO paciente (identificacion,tipodoc,papellido,sapellido,pnombre,snombre,fechanac,sexo, direccion, telefono, email,municipio,barrio, zona, niveleducativo, ocupacion, etnia ) VALUES("+
                            "@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10,@param11,@param12,@param13,@param14,@param15,@param16,@param17)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@param1", p.id);
            cmd.Parameters.AddWithValue("@param2", p.tipodoc);
            cmd.Parameters.AddWithValue("@param3", p.papellido);
            cmd.Parameters.AddWithValue("@param4", p.sapellido);
            cmd.Parameters.AddWithValue("@param5", p.pnombre);
            cmd.Parameters.AddWithValue("@param6", p.snombre);
            cmd.Parameters.AddWithValue("@param7", p.fechanac);
            cmd.Parameters.AddWithValue("@param8", p.sexo);
            cmd.Parameters.AddWithValue("@param9", p.direccion);
            cmd.Parameters.AddWithValue("@param10", p.telefono);
            cmd.Parameters.AddWithValue("@param11", p.email);
            cmd.Parameters.AddWithValue("@param12", p.municipio);
            cmd.Parameters.AddWithValue("@param13", p.barrio);
            cmd.Parameters.AddWithValue("@param14", p.zona);
            cmd.Parameters.AddWithValue("@param15", p.niveleducativo);
            cmd.Parameters.AddWithValue("@param16", p.ocupacion);
            cmd.Parameters.AddWithValue("@param17", p.etnia);
            result = cmd.ExecuteNonQuery();
            return result;
        }

        //guardar paciente
        public int SaveAnamensis(Anamnesis a)
        {
            int result = 0;
            MySqlConnection con = Conexion.obtenerConexion();
            MySqlCommand cmd = con.CreateCommand();
            //string query = "INSERT INTO paciente (identificacion,tipodoc,papellido,sapellido,pnombre,snombre,fechanac,sexo) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)";
            string query = "INSERT INTO hc_anamnesis (id_paciente,motivo_consulta,enfermedad_actual,organos,obs_organos,"+
                            "sist_cardio,obs_cardio,sist_respi,obs_respi,digestivo,obs_digestivo,"+
                            "sist_genito,obs_genito,sist_endocrino,obs_endocrino,sist_hemato,obs_hemato,"+
                            "sist_musculoesq,obs_musculoesq,sist_nervioso,obs_nervioso,estado_mental,obs_mental,sist_tegumentario,obs_tegu ) VALUES(" +
                            "@param1,@param2,@param3,@param4,@param5,@param6,@param7,"+
                            "@param8,@param9,@param10,@param11,@param12,@param13,@param14,"+
                            "@param15,@param16,@param17,@param18,@param19,@param20,@param21,"+
                            "@param22,@param23,@param24,@param25)";
            cmd.CommandText = query;           
            cmd.Parameters.AddWithValue("@param1", a.id_paciente);
            cmd.Parameters.AddWithValue("@param2", a.motivo_consulta);
            cmd.Parameters.AddWithValue("@param3", a.enfermedad_actual);
            cmd.Parameters.AddWithValue("@param4", a.organos);
            cmd.Parameters.AddWithValue("@param5", a.obs_organos);
            cmd.Parameters.AddWithValue("@param6", a.sist_cardio);
            cmd.Parameters.AddWithValue("@param7", a.obs_cardio);
            cmd.Parameters.AddWithValue("@param8", a.sist_respi);
            cmd.Parameters.AddWithValue("@param9", a.obs_respi);
            cmd.Parameters.AddWithValue("@param10", a.sist_genito);
            cmd.Parameters.AddWithValue("@param11", a.obs_genito);
            cmd.Parameters.AddWithValue("@param12", a.digestivo);
            cmd.Parameters.AddWithValue("@param13", a.obs_digestivo);
            cmd.Parameters.AddWithValue("@param14", a.sist_endocrino);
            cmd.Parameters.AddWithValue("@param15", a.obs_endocrino);
            cmd.Parameters.AddWithValue("@param16", a.sist_hemato);
            cmd.Parameters.AddWithValue("@param17", a.obs_hemato);
            cmd.Parameters.AddWithValue("@param18", a.sist_musculoesq);
            cmd.Parameters.AddWithValue("@param19", a.obs_musculoesq);
            cmd.Parameters.AddWithValue("@param20", a.sist_nervioso);
            cmd.Parameters.AddWithValue("@param21", a.obs_nervioso);
            cmd.Parameters.AddWithValue("@param22", a.estado_mental);
            cmd.Parameters.AddWithValue("@param23", a.obs_mental);
            cmd.Parameters.AddWithValue("@param24", a.sist_tegumentario);
            cmd.Parameters.AddWithValue("@param25", a.tegu);
            result = cmd.ExecuteNonQuery();
            return result;
        }

        public int SaveAntecedentes(Antecedentes a)
        {
            int result = 0;
            MySqlConnection con = Conexion.obtenerConexion();
            MySqlCommand cmd = con.CreateCommand();
            //string query = "INSERT INTO paciente (identificacion,tipodoc,papellido,sapellido,pnombre,snombre,fechanac,sexo) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8)";
            string query = "INSERT INTO hc_antecedentes (id_paciente,ant_hipert,obs_ant_hipert,cardiopatia,obs_cardiopatia," +
                            "infarto_miocardio,obs_infarto,otrapato,obs_otrapato,ant_cirugia,obs_ant_cirugia," +
                            "traumatico,obs_traumatico,toxico,obs_toxico,transfusion,obs_transfusion," +
                            "hospitalario,obs_hospitalario,alergicos,obs_alergicos,gineco,obs_gineco,familiares,tabaquismo,conducta_alimento,estres,otro ) VALUES(" +
                            "@param1,@param2,@param3,@param4,@param5,@param6,@param7," +
                            "@param8,@param9,@param10,@param11,@param12,@param13,@param14," +
                            "@param15,@param16,@param17,@param18,@param19,@param20,@param21," +
                            "@param22,@param23,@param24,@param25,@param26,@param27,@param28)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@param1", a.id_paciente);
            cmd.Parameters.AddWithValue("@param2", a.ant_hipert);
            cmd.Parameters.AddWithValue("@param3", a.obs_ant_hipert);
            cmd.Parameters.AddWithValue("@param4", a.cardiopatia);
            cmd.Parameters.AddWithValue("@param5", a.obs_cardiopatia);
            cmd.Parameters.AddWithValue("@param6", a.infarto_miocardio);
            cmd.Parameters.AddWithValue("@param7", a.obs_infarto);
            cmd.Parameters.AddWithValue("@param8", a.otrapato);
            cmd.Parameters.AddWithValue("@param9", a.obs_otrapato);
            cmd.Parameters.AddWithValue("@param10", a.ant_cirugia);
            cmd.Parameters.AddWithValue("@param11", a.obs_ant_cirugia);
            cmd.Parameters.AddWithValue("@param12", a.traumatico);
            cmd.Parameters.AddWithValue("@param13", a.obs_traumatico);
            cmd.Parameters.AddWithValue("@param14", a.toxico);
            cmd.Parameters.AddWithValue("@param15", a.obs_toxico);
            cmd.Parameters.AddWithValue("@param16", a.transfusion);
            cmd.Parameters.AddWithValue("@param17", a.obs_transfusion);
            cmd.Parameters.AddWithValue("@param18", a.hospitalario);
            cmd.Parameters.AddWithValue("@param19", a.obs_hospitalario);
            cmd.Parameters.AddWithValue("@param20", a.alergicos);
            cmd.Parameters.AddWithValue("@param21", a.obs_alergicos);
            cmd.Parameters.AddWithValue("@param22", a.gineco);
            cmd.Parameters.AddWithValue("@param23", a.obs_gineco);
            cmd.Parameters.AddWithValue("@param24", a.familiares);
            cmd.Parameters.AddWithValue("@param25", a.tabaquismo);
            cmd.Parameters.AddWithValue("@param26", a.conducta_alimento);
            cmd.Parameters.AddWithValue("@param27", a.estres);
            cmd.Parameters.AddWithValue("@param28", a.otro);
            result = cmd.ExecuteNonQuery();
            return result;
        }

        public int SaveExamen(Examen p)
        {
            int result = 0;
            MySqlConnection con = Conexion.obtenerConexion();
            MySqlCommand cmd = con.CreateCommand();            
            string query = "INSERT INTO hc_examen_fisico (idpaciente,tension_art_sist,tension_art_dist,frec_cardiaca,frec_respiratoria,temperatura,peso,talla,tension_art_media, imc, aspecto_gen_paciente,cabeza,cuello,torax,pulmon,exam_cardiovas,abdomen,genitales,musculoesq,neurologico,piel,fanera) VALUES(" +
                            "@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10,@param11,@param12,@param13,@param14,@param15,@param16,@param17,@param18,@param19,@param20,@param21,@param22)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@param1", p.id_paciente);
            cmd.Parameters.AddWithValue("@param2", p.tension_sistolica);
            cmd.Parameters.AddWithValue("@param3", p.tension_diastolica);
            cmd.Parameters.AddWithValue("@param4", p.frec_cardiaca);
            cmd.Parameters.AddWithValue("@param5", p.frec_respiratoria);
            cmd.Parameters.AddWithValue("@param6", p.temp);
            cmd.Parameters.AddWithValue("@param7", p.peso);
            cmd.Parameters.AddWithValue("@param8", p.talla);
            cmd.Parameters.AddWithValue("@param9", p.tension_media);
            cmd.Parameters.AddWithValue("@param10", p.imc);
            cmd.Parameters.AddWithValue("@param11", p.aspecto);
            cmd.Parameters.AddWithValue("@param12", p.cabeza);
            cmd.Parameters.AddWithValue("@param13", p.cuello);
            cmd.Parameters.AddWithValue("@param14", p.torax);
            cmd.Parameters.AddWithValue("@param15", p.pulmon);
            cmd.Parameters.AddWithValue("@param16", p.exam_cardio);
            cmd.Parameters.AddWithValue("@param17", p.abdomen);
            cmd.Parameters.AddWithValue("@param18", p.genitales);
            cmd.Parameters.AddWithValue("@param19", p.exa_musculo);
            cmd.Parameters.AddWithValue("@param20", p.exa_neuro);
            cmd.Parameters.AddWithValue("@param21", p.piel);
            cmd.Parameters.AddWithValue("@param22", p.fanera);
            result = cmd.ExecuteNonQuery();
            return result;
        }

        public int SaveAdmision(Admisiones a)
        {
            int result = 0;
            MySqlConnection con = Conexion.obtenerConexion();
            MySqlCommand cmd = con.CreateCommand();
            string query = "INSERT INTO admisiones (historia,fechaadm ,id_contrato,id_programa,acudi_nombre,acudi_parentesco,direccion,telefono,responsable,observaciones) VALUES(" +
                            "@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10)";
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@param1", a.historia);
            cmd.Parameters.AddWithValue("@param2", a.fechaAdm);
            cmd.Parameters.AddWithValue("@param3", a.id_contrato);
            cmd.Parameters.AddWithValue("@param4", a.id_programa);
            cmd.Parameters.AddWithValue("@param5", a.acudi_nombre);
            cmd.Parameters.AddWithValue("@param6", a.acudi_parentesco);
            cmd.Parameters.AddWithValue("@param7", a.direccion);
            cmd.Parameters.AddWithValue("@param8", a.telefono);
            cmd.Parameters.AddWithValue("@param9", a.responsable);
            cmd.Parameters.AddWithValue("@param10", a.responsable);            
            result = cmd.ExecuteNonQuery();
            return result;
        }

        //Obtiene la lista de paciente
        public List<Paciente> GetListaPaciente()
        {
            List<Paciente> lista = new List<Paciente>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM paciente";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        Paciente p = new Paciente();
                        p.id = Convert.ToInt32(sdr["identificacion"]);
                        p.tipodoc = sdr["tipodoc"].ToString();
                        p.papellido = sdr["papellido"].ToString();
                        p.sapellido = sdr["sapellido"].ToString();
                        p.pnombre = sdr["pnombre"].ToString();
                        p.snombre = sdr["snombre"].ToString();
                            //fechanac = Convert.ToDateTime(sdr["fechanac"].ToString()),
                        p.fechanac = (sdr["fechanac"].ToString());
                        p.sexo = sdr["sexo"].ToString();
                        p.direccion = sdr["direccion"].ToString();
                        p.telefono = sdr["telefono"].ToString();
                        p.municipio = sdr["municipio"].ToString();
                        p.barrio = sdr["barrio"].ToString();
                        p.zona = sdr["zona"].ToString();
                        p.niveleducativo = Convert.ToInt32(sdr["niveleducativo"]);
                        p.ocupacion = Convert.ToInt32(sdr["ocupacion"]);
                        p.email = sdr["email"].ToString();
                        lista.Add(p);                        
                    }
                }
                con.Close();
            }
            return lista;
        }

        public List<Paciente> GetPaciente(string id)
        {
            List<Paciente> lista = new List<Paciente>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM paciente where identificacion=";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        Paciente p = new Paciente();
                        p.id = Convert.ToInt32(sdr["identificacion"]);
                        p.tipodoc = sdr["tipodoc"].ToString();
                        p.papellido = sdr["papellido"].ToString();
                        p.sapellido = sdr["sapellido"].ToString();
                        p.pnombre = sdr["pnombre"].ToString();
                        p.snombre = sdr["snombre"].ToString();
                        //fechanac = Convert.ToDateTime(sdr["fechanac"].ToString()),
                        p.fechanac = (sdr["fechanac"].ToString());
                        p.sexo = sdr["sexo"].ToString();
                        p.direccion = sdr["direccion"].ToString();
                        p.telefono = sdr["telefono"].ToString();
                        p.municipio = sdr["municipio"].ToString();
                        p.barrio = sdr["barrio"].ToString();
                        p.zona = sdr["zona"].ToString();
                        p.niveleducativo = Convert.ToInt32(sdr["niveleducativo"]);
                        p.ocupacion = Convert.ToInt32(sdr["ocupacion"]);
                        p.email = sdr["email"].ToString();
                        lista.Add(p);
                    }
                }
                con.Close();
            }
            return lista;
        }

        public int Edad(DateTime fechaNacimiento)
        {
            //Obtengo la diferencia en años.
            int edad = DateTime.Now.Year - fechaNacimiento.Year;

            //Obtengo la fecha de cumpleaños de este año.
            DateTime nacimientoAhora = fechaNacimiento.AddYears(edad);
            //Le resto un año si la fecha actual es anterior 
            //al día de nacimiento.
            if (DateTime.Now.CompareTo(nacimientoAhora) > 0)
            {
                edad--;
            }

            return edad;
        }

        public List<Paciente> ObtenerPaciente(string id)
        {
            List<Paciente> lista = new List<Paciente>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM paciente where identificacion = "+id;
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        lista.Add(new Paciente
                        {
                            id = Convert.ToInt32(sdr["identificacion"]),
                            tipodoc = sdr["tipodoc"].ToString(),
                            papellido = sdr["papellido"].ToString(),
                            sapellido = sdr["sapellido"].ToString(),
                            pnombre = sdr["pnombre"].ToString(),
                            snombre = sdr["snombre"].ToString(),
                            fechanac = (sdr["fechanac"].ToString()),                            
                            sexo = sdr["sexo"].ToString(),
                            direccion = sdr["direccion"].ToString(),
                            telefono = sdr["telefono"].ToString(),
                            municipio = sdr["municipio"].ToString(),
                            barrio = sdr["barrio"].ToString(),
                            zona = sdr["zona"].ToString(),
                            niveleducativo = Convert.ToInt32(sdr["niveleducativo"]),
                            ocupacion = Convert.ToInt32(sdr["ocupacion"]),
                            email = sdr["email"].ToString()
                        });
                    }
                }
                con.Close();
            }
            return lista;
        }

        //Metodo que trae todas las etnias
        public List<Etnia> GetEtnia()
        {
            List<Etnia> listaEtnia = new List<Etnia>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM etnia";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        listaEtnia.Add(new Etnia
                        {
                            id = Convert.ToInt32(sdr["codigo"]),
                            nombre = sdr["nombre"].ToString(),
                        });
                    }
                }
                con.Close();
            }
            return listaEtnia;
        }

        //Metodo que trae todos los tipos de identificación
        public List<TipoDocumento> GetTipoDocumento()
        {
            List<TipoDocumento> lista = new List<TipoDocumento>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM tipo_identificacion";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        lista.Add(new TipoDocumento
                        {
                            id = sdr["codigo"].ToString(),
                            nombre = sdr["nombre"].ToString(),
                        });
                    }
                }
                con.Close();
            }
            return lista;
        }
        
        //Metodo que trae el sexo
        public List<Sexo> GetSexo()
        {
            List<Sexo> lista = new List<Sexo>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM Sexo";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        lista.Add(new Sexo
                        {
                            id = sdr["codigo"].ToString(),
                            nombre = sdr["nombre"].ToString(),
                        });
                    }
                }
                con.Close();
            }
            return lista;
        }

        //Metodo que trae el nivel_educativo
        public List<Educativo> GetEducativo()
        {
            List<Educativo> lista = new List<Educativo>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM nivel_educativo";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        lista.Add(new Educativo
                        {
                            id = Convert.ToInt32(sdr["codigo"]),
                            nombre = sdr["nombre"].ToString(),
                        });
                    }
                }
                con.Close();
            }
            return lista;
        }
        
        //Metodo que trae LA Zona
        public List<Zona> GetZona()
        {
            List<Zona> lista = new List<Zona>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM zona";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        lista.Add(new Zona
                        {
                            id = sdr["id"].ToString(),
                            nombre = sdr["nombre"].ToString(),
                        });
                    }
                }
                con.Close();
            }
            return lista;
        }

        //Metodo que trae LA Municipio
        public List<Municipio> GetMunicipio()
        {
            List<Municipio> lista = new List<Municipio>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM municipio";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        lista.Add(new Municipio
                        {
                            id = sdr["id"].ToString(),
                            nombre = sdr["nombre"].ToString(),
                        });
                    }
                }
                con.Close();
            }
            return lista;
        }

        //Metodo que trae Ocupación
        public List<Ocupacion> GetOcupacion()
        {
            List<Ocupacion> lista = new List<Ocupacion>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM ciuo";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        lista.Add(new Ocupacion
                        {
                            id = Convert.ToInt32(sdr["codigo"]),
                            nombre = sdr["nombre"].ToString(),
                        });
                    }
                }
                con.Close();
            }
            return lista;
        }

        //Metodo que trae Contrato
        public List<Contrato> GetContrato()
        {
            List<Contrato> lista = new List<Contrato>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM contrato";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        lista.Add(new Contrato
                        {
                            id = sdr["id"].ToString(),
                            contrato = sdr["contrato"].ToString(),
                        });
                    }
                }
                con.Close();
            }
            return lista;
        }

        //Metodo que trae el servicio y valor
        public List<Cups> GetCups(string Name)
        {
            List<Cups> lista = new List<Cups>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM cups WHERE nombre LIKE @param";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@param", "%" + Name + "%");
                cmd.Connection = con;                
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        lista.Add(new Cups
                        {
                            codigo = sdr["codigo"].ToString(),
                            nombre = sdr["nombre"].ToString(),
                            valor_soat = sdr["valor_soat"].ToString(),
                            valor_iss = sdr["valor_iss"].ToString(),
                        });
                    }
                }
                con.Close();
            }
            return lista;
        }

        //Metodo que trae Programa
        public List<Programa> GetPrograma()
        {
            List<Programa> lista = new List<Programa>();
            MySqlConnection con = Conexion.obtenerConexion();
            string query = "SELECT * FROM programa";
            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = con;
                //con.Open();
                using (MySqlDataReader sdr = cmd.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        lista.Add(new Programa
                        {
                            id = sdr["id"].ToString(),
                            programa = sdr["programa"].ToString(),
                        });
                    }
                }
                con.Close();
            }
            return lista;
        }
    }
}