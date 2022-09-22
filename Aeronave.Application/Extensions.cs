using Aeronave.Domain.Factories;
using Microsoft.Extensions.DependencyInjection;

namespace Aeronave.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<IVueloFactory, VueloFactory>();
        services.AddTransient<IAeronaveFactory, AeronaveFactory>();
        return services;
    }
}