using CentroMedicoAPI.Models;
using System;
using System.Data.SqlClient;

namespace CentroMedicoAPI.Data
{
    public class HistoriamedicaData
    {

        public static bool insertarHistoriamedica(Historiamedica oHistoriamedica)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp insertar '" + oHistoriamedica.Idhistoria + "','" + oHistoriamedica.Idpaciente
           + "','" + oHistoriamedica.Fechaingreso + "','" + oHistoriamedica.Estadohistoria + "','" + oHistoriamedica.Concepto + "'; '" + oHistoriamedica.Observaciones + "'";

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

        public static bool actualizarHistoriamedica(Historiamedica oHistoriamedica)
        {
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp actualizar '" + oHistoriamedica.Idhistoria + "','" + oHistoriamedica.Idpaciente
        + "','" + oHistoriamedica.Fechaingreso + "','" + oHistoriamedica.Estadohistoria + "','" + oHistoriamedica.Concepto + "'";
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
        public static bool eliminarHistoriamedica(string id)
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
        public static List<Historiamedica> Listar()
        {
            List<Historiamedica> oListaHistoriamedica = new List<Historiamedica>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp_listar";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;

                while (dr.Read())
                {
                    oListaHistoriamedica.Add(new Historiamedica()
                    {
                        Idhistoria = Convert.ToInt32(dr["Idhistoria"]),
                        Idmedico = Convert.ToInt32(dr["Idmedico"]),
                        Idpaciente = Convert.ToInt32(dr["Idpaciente"]),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString()),
                        Estadohistoria = dr["Estadocita"].ToString(),
                        Concepto = dr["Concepto"].ToString(),
                        Observaciones = dr["Observaciones"].ToString()

                    });
                }
                return oListaHistoriamedica;
            }
            else
            {
                return oListaHistoriamedica;
            }
        }
        public static List<Historiamedica> Consultar(string id)
        {
            List<Historiamedica> oListaHistoriamedica = new List<Historiamedica>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp_Consultar '" + id + "'";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;
                while (dr.Read())
                {
                    oListaHistoriamedica.Add(new Historiamedica()
                    {
                        Idhistoria = Convert.ToInt32(dr["Idhistoria"]),
                        Idmedico = Convert.ToInt32(dr["Idmedico"]),
                        Idpaciente = Convert.ToInt32(dr["Idpaciente"]),
                        FechaIngreso = Convert.ToDateTime(dr["FechaIngreso"].ToString()),
                        Estadohistoria = dr["Estadocita"].ToString(),
                        Concepto = dr["Concepto"].ToString(),
                        Observaciones = dr["Observaciones"].ToString()
                    });
                }
                return oListaHistoriamedica;
            }
            else
            {
                return oListaHistoriamedica;
            }
        }

    }
        

    
}
