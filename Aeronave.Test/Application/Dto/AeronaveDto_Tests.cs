using Aeronave.Application.Dto.Aeronave;
using Aeronave.Domain.Model.Aeronaves;
using System;
using Xunit;

namespace Aeronave.Test.Application.Dto
{
    public class AeronaveDto_Tests
    {
        [Fact]
        public void AeronaveDto_CheckPropertiesValid()
        {
            var idTest = Guid.NewGuid();
            var detalleAeronaveTest = MockFactoryGeneric.GetDetalleAeronave();
            var objAeronave = new AeronaveDto();
            Assert.Equal(Guid.Empty, objAeronave.Id);
            Assert.Equal(Estado.Operativo, objAeronave.EstadoAeronave);
            Assert.NotNull(objAeronave.Detalle);

            objAeronave.Id = idTest;
            objAeronave.Detalle = detalleAeronaveTest;
            Assert.Equal(idTest, objAeronave.Id);
            Assert.Equal(detalleAeronaveTest, objAeronave.Detalle);
        }
    }
}