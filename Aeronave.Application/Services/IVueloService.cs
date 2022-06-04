namespace Aeronave.Application.Services
{
    public interface IVueloService
    {
        Task<string> GenerarNroVueloAsync();
    }
}