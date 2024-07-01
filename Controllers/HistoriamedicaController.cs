using CentroMedicoAPI.Data;
using CentroMedicoAPI.Models;
using Microsoft.AspNetCore.Mvc;



namespace CentroMedicoAPI.Controllers
{

    public class HistoriamedicaController : ControllerBase
    {

        // GET api/<controller>
        public  List<Historiamedica> Get()
        {
            return HistoriamedicaData.Listar();
        }
        // GET api/<controller>/5
        public List<Historiamedica> Get(string id)
        {
            return HistoriamedicaData.Consultar(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Historiamedica oHistoriamedica)
        {
            return HistoriamedicaData.insertarHistoriamedica(oHistoriamedica);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Historiamedica oHistoriamedica)
        {
            return HistoriamedicaData.actualizarHistoriamedica(oHistoriamedica);
        }
        // DELETE api/<controller>/5
        public bool Eliminar(string id)
        {
            return HistoriamedicaData.eliminarHistoriamedica(id);
        }
    }

}

