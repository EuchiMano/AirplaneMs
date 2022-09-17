namespace Aeronave.Application.Dto.Vuelo;

public class VueloDto
{
    public Guid NroVuelo { get; set; }
    public Guid AeronaveId { get; set; }
    public string Estado { get; set; }
    public DateTime Fecha { get; set; }
    public Guid AeropuertoOrigen { get; set; }
    public Guid AeropuertoDestino { get; set; }
}