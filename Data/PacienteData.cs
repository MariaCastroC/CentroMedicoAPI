using CentroMedicoAPI.Models;
using System.Data.SqlClient;

namespace CentroMedicoAPI.Data
{
    public class PacienteData
    
    {
          public static bool insertarPaciente(Paciente oPaciente)
          {
                ConexionBD objEst = new ConexionBD();
                string sentencia;
                sentencia = "EXECUTE sp insertar '" + oPaciente.Idpaciente + "','" + oPaciente.Nombrepaciente
               + "','" + oPaciente.Apellidopaciente + "','" + oPaciente.Direccionpaciente + "','" + oPaciente.Estadopaciente + "'; '" + oPaciente.Correo + "'; '" + oPaciente.Fechanacimiento + "'";

                if (!objEst.EjecutarSentencia(sentencia, false))
                {
                    objEst = null;
                    return false;
                }
                else
                {
                    objEst = null;
                    return true;
                }

            }

            public static bool actualizarPaciente(Paciente oPaciente)
            {
                ConexionBD objEst = new ConexionBD();
                string sentencia;
                sentencia = "EXECUTE sp actualizar '" + oPaciente.Idpaciente + "','" + oPaciente.Nombrepaciente
               + "','" + oPaciente.Apellidopaciente + "','" + oPaciente.Direccionpaciente + "','" + oPaciente.Estadopaciente + "'; '" + oPaciente.Correo + "'; '" + oPaciente.Fechanacimiento + "'";
            if (!objEst.EjecutarSentencia(sentencia, false))
                {
                    objEst = null;
                    return false;
                }
                else
                {
                    objEst = null;
                    return true;
                }
            }
            public static bool eliminarPaciente(string id)
            {
                ConexionBD objEst = new ConexionBD();
                string sentencia;
                sentencia = "EXECUTE sp_Eliminar '" + id + "'";
                if (!objEst.EjecutarSentencia(sentencia, false))
                {
                    objEst = null;
                    return false;
                }
                else
                {
                    objEst = null;
                    return true;
                }
            }

        public static List<Paciente> Listar()
        {
            List<Paciente> oListaPaciente = new List<Paciente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp_listar";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaPaciente.Add(new Paciente()
                    {
                        Idpaciente = Convert.ToInt32(dr["Idpaciente"]),
                        Nombrepaciente = dr["Nombrepaciente"].ToString(),
                        Apellidopaciente = dr["Apellidopaciente"].ToString(),
                        Direccionpaciente = dr["Direccionpaciente"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Fechanacimiento = Convert.ToDateTime(dr["Fechanacimiento"].ToString()),
                        Estadopaciente = dr["Estadopaciente"].ToString()
                    });
                }
                return oListaPaciente;
            }
            else
            {
                return oListaPaciente;
            }
        
       
         }
        public static List<Paciente> Consultar(string id)
        {
            List<Paciente> oListPaciente = new List<Paciente>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp_Consultar '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaHistoriamedica.Add(new Paciente()
                    {
                        Idpaciente = Convert.ToInt32(dr["Idpaciente"]),
                        Nombrepaciente = dr["Nombrepaciente"].ToString(),
                        Apellidopaciente = dr["Apellidopaciente"].ToString(),
                        Direccionpaciente = dr["Direccionpaciente"].ToString(),
                        Correo = dr["Correo"].ToString(),
                        Fechanacimiento = Convert.ToDateTime(dr["Fechanacimiento"].ToString()),
                        Estadopaciente = dr["Estadopaciente"].ToString()
                    });
                }
                return oListaPaciente;
            }
            else
            {
                return oListaPaciente;
            }
        }
    }

}

