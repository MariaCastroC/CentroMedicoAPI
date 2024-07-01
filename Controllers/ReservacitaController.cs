using CentroMedicoAPI.Data;
using CentroMedicoAPI.Models;
using Microsoft.AspNetCore.Mvc;



namespace CentroMedicoAPI.Controllers
{
   
    public class ReservacitaController : ControllerBase
    {
        
        // GET api/<controller>
        public List<Reservacita> Get()
        {
            return ReservacitaData.Listar();
        }
        // GET api/<controller>/5
        public List<Reservacita> Get(string id)
        {
            return ReservacitaData.Consultar(id);
        }
        // POST api/<controller>
        public bool Post([FromBody] Reservacita oReservacita)
        {
            return ReservacitaData.insertarReservacita(oReservacita);
        }
        // PUT api/<controller>/5
        public bool Put([FromBody] Reservacita oReservacita)
        {
            return ReservacitaData.actualizarReservacita(oReservacita);
        }
        // DELETE api/<controller>/5
        public bool Delete(string id)
        {
            return ReservacitaData.eliminarReservacita(id);
        }

    }

}
