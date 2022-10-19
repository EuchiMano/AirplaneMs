using Aeronave.Domain.Model.Aeronaves.ValueObjects;
using SharedKernel.Core;
using Xunit;

namespace Aeronave.Test.Domain.Model.Aeronaves.ValueObjects;

public class NrodeAsientosTests
{
    [Fact]
    public void NroAsientosCorrectly()
    {
        var nroAsientos = 100;


        var valueObject = new NroAsientos(nroAsientos);
        Assert.Equal(nroAsientos, valueObject.Value);

    }

    //[Fact]
    //public void NroAsientosFail()
    //{
    //	var nroAsientosBad = -50;
    //	var valueObject = new NroAsientos(nroAsientosBad)

    //}
}