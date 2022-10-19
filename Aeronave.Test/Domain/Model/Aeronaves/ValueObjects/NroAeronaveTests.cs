using Aeronave.Domain.Model.Aeronaves.ValueObjects;
using Xunit;

namespace Aeronave.Test.Domain.Model.Aeronaves.ValueObjects;

public class NroAeronaveTests
{
    [Fact]
    public void NroAeronaveCorrectly()
    {
        var nroAeronave = "asd123";


        var valueObject = new NumeroAeronave(nroAeronave);
        Assert.Equal(nroAeronave, valueObject.Value);
    }
}