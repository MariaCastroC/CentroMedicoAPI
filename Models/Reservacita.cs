namespace CentroMedicoAPI.Models
{
    public class Reservacita
    {
        public required int Idcita { get; set; }
        public required int Idpaciente { get; set; }
        public required int Idhorario { get; set; }
        public required int Idconsultorio { get; set; }
        public DateTime Fechaingreso { get; set; }
        public required string Estadocita { get; set; }
    }
}
