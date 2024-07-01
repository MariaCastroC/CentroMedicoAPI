using CentroMedicoAPI.Models;
using System;
using System.Data.SqlClient;

namespace CentroMedicoAPI.Data
{
    public class ReservacitaData
    {
        public static bool insertarReservacita(Reservacita oReservacita)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp insertar '" + oReservacita.Idcita + "','" + oReservacita.Idpaciente
           + "','" + oReservacita.Idhorario + "','" + oReservacita.Idconsultorio + "'; '" + oReservacita.Fechaingreso + "','" + oReservacita.Estadocita + "'";

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

        public static bool actualizarReservacita(Reservacita oReservacita)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp actualizar '" + oReservacita.Idcita + "','" + oReservacita.Idpaciente
           + "','" + oReservacita.Idhorario + "','" + oReservacita.Idconsultorio + "'; '" + oReservacita.Fechaingreso + "','" + oReservacita.Estadocita + "'";
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
        public static bool eliminarReservacita(string id)
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

        public static List<Reservacita> Listar()
        {
            List<Reservacita> oListaReservacita = new List<Reservacita>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp_listar";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaReservacita.Add(new Reservacita()
                    {
                        Idcita = Convert.ToInt32(dr["IdCita"]),
                        Idpaciente = Convert.ToInt32(dr["IdPaciente"]),
                        Idhorario = Convert.ToInt32(dr["Idhorario"]),
                        Idconsultorio = Convert.ToInt32(dr["IdConsultorio"]),
                        Fechaingreso = Convert.ToDateTime(dr["Fechaingreso"].ToString()),
                        Estadocita = dr["Estadocita"].ToString()
                        
                    });
                }
                return oListaReservacita;
            }
            else
            {
                return oListaReservacita;
            }


        }
        public static List<Reservacita> Consultar(string id)
        {
            List<Reservacita> oListaReservacita = new List<Reservacita>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp_Consultar '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaReservacita.Add(new Reservacita()

                    {
                        Idcita = Convert.ToInt32(dr["IdCita"]),
                        Idpaciente = Convert.ToInt32(dr["IdPaciente"]),
                        Idhorario = Convert.ToInt32(dr["Idhorario"]),
                        Idconsultorio = Convert.ToInt32(dr["IdConsultorio"]),
                        Fechaingreso = Convert.ToDateTime(dr["Fechaingreso"].ToString()),
                        Estadocita = dr["Estadocita"].ToString()
                    });
                }
                return oListaReservacita;
            }
            else
            {
                return oListaReservacita;
            }
        }
    }

}

    

