namespace Aeronave.Application.Services
{
    public interface IAeronaveService
    {
        Task<string> GenerarNroAeronaveAsync();
    }
}