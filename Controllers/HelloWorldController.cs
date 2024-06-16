using Microsoft.AspNetCore.Mvc;


// clasede ejemplo para crear un controlador leer sobre protocolo web REST 
namespace CentroMedicoAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {

        [HttpGet(Name = "HelloWorld")]
        public string Get()
        {
            return "Hello World!!";
        }

    }
}
