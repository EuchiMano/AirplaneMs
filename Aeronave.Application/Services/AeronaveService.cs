namespace Aeronave.Application.Services
{
    public class AeronaveService : IAeronaveService
    {
        public Task<string> GenerarNroAeronaveAsync() => Task.FromResult("ABC");
    }
}