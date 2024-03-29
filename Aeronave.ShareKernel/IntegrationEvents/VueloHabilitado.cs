﻿using SharedKernel.Core;

namespace SharedKernel.IntegrationEvents;

public record VueloHabilitado : IntegrationEvent
{
    public DateTime horaSalida { get; set; }
    public DateTime horaLLegada { get; set; }
    public string estado { get; set; }
    public decimal precio { get; set; }
    public DateTime fecha { get; set; }
    public Guid codRuta { get; set; }
    public Guid codAeronave { get; set; }
    public int activo { get; set; }
    public int stockAsientos { get; set; }
    public Guid vueloId { get; set; }
}
