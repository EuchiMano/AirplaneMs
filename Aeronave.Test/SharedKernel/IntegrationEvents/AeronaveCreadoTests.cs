using System;
using SharedKernel.IntegrationEvents;
using Xunit;

namespace Aeronave.Test.SharedKernel.IntegrationEvents;

public class AeronaveCreadoTests
{
    [Fact]
    public void AeronaveCreadoCorrectly()
    {
        var aeronaveId = Guid.NewGuid();

        var valueObject = new AeronaveCreado();
        valueObject.AeronaveId = aeronaveId;

        Assert.Equal(aeronaveId, valueObject.AeronaveId);
        Assert.IsType<Guid>(valueObject.EventId);
        Assert.IsType<DateTime>(valueObject.OccuredOn);
    }
}