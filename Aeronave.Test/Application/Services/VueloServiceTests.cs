using Aeronave.Application.Services;
using Xunit;

namespace Aeronave.Test.Application.Services
{
    public class VueloServiceTests
    {
        [Theory]
        [InlineData("ABC", true)]
        [InlineData("123", false)]
        [InlineData("456", false)]
        [InlineData("789", false)]
        [InlineData("111", false)]
        [InlineData("sss", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public async void GenerarPedido_CheckValidData(string expectedNroVuelo, bool isEqual)
        {
            var vueloService = new VueloService();
            string nroPedido = await vueloService.GenerarNroVueloAsync();
            if (isEqual)
            {
                Assert.Equal(expectedNroVuelo, nroPedido);
            }
            else
            {
                Assert.NotEqual(expectedNroVuelo, nroPedido);
            }
        }
    }
}