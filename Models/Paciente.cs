namespace CentroMedicoAPI.Models
{
    public class Paciente
    {
        public required int Idpaciente { get; set; }
        public required string Nombrepaciente { get; set; }
        public required string Apellidopaciente { get; set; }
        public required string Direccionpaciente { get; set; }
        public required string Correo { get; set; }
        public DateTime Fechanacimiento { get; set; }
        public required string Estadopaciente { get; set; }
    }
}
