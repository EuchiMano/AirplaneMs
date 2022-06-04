namespace Aeronave.Application.Services
{
    public class VueloService : IVueloService
    {
        public Task<string> GenerarNroVueloAsync() => Task.FromResult("ABC");
    }
}