using CentroMedicoAPI.Data;
using CentroMedicoAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CentroMedicoAPI.Controllers
{

        public class PacienteController : ControllerBase
        {

            // GET api/<controller>
            public List<Paciente> Get()
            {
                return PacienteData.Listar();
            }
            // GET api/<controller>/5
            public List<Paciente> Get(string id)
            {
                return PacienteData.Consultar(id);
            }
            // POST api/<controller>
            public bool Post([FromBody] Paciente oPaciente)
            {
                return PacienteData.insertarPaciente(oPaciente);
            }
            // PUT api/<controller>/5
            public bool Put([FromBody] Paciente oPaciente)
            {
                return PacienteData.actualizarPaciente(oPaciente);
            }
            // DELETE api/<controller>/5
            public bool Eliminar(string id)
            {
                return PacienteData.eliminarPaciente(id);
            }
        }

}
 


