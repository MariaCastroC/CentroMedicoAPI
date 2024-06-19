namespace CentroMedicoAPI.Models
{
    public class Historiamedica
    {

        public int Idhistoria { get; set; }
        public int Idpaciente { get; set; }
        public DateTime Fechaingreso { get; set; }
        public required string Estadohistoria { get; set; }
        public required string Concepto { get; set; }
        public required string Observaciones { get; set; }

    }
}
