namespace Aeronave.Infraestructure.EF.ReadModel
{
    public class VueloReadModel
    {
        public Guid NroVuelo { get; set; }
        public Guid AeronaveId { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        public Guid AeropuertoOrigen { get; set; }
        public Guid AeropuertoDestino { get; set; }
    }
}