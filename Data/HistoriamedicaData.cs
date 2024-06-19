using CentroMedicoAPI.Models;
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
            sentencia = "EXECUTE usp_Eliminar '" + id + "'";
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
            List<Historiamedica> oListarHistoriamedica = new List<Historiamedica>();
            ConexionBD objEst = new ConexionBD();
            string sentencia;
            sentencia = "EXECUTE sp_listar";
            if (objEst.Consultar(sentencia, false))
            {
                SqlDataReader dr = objEst.Reader;

     
                while (dr.Read())
                {
                    Historiamedica historiamedica = new()
                    {
                        Idhistoria = Convert.ToInt32(dr["Idhistoriamedica"]),
                        Estadohistoria = dr["Estadohistoria"].ToString(),
                        Concepto = dr["Concepto"].ToString(),
                        Idpaciente = Convert.ToInt32(dr["Idpaciente"]),
                        Observaciones = dr["Observaciones"].ToString(),
                        Fechaingreso = Convert.ToDateTime(dr["Fechaingreso"].ToString())
                    };

                    oListarHistoriamedica.Add(historiamedica);
                }
                return oListarHistoriamedica;
            }
            else
            {
                return oListarHistoriamedica;
            }
        }

    }
}
