using Aeronave.Application.Services;
using Aeronave.Domain.Factories;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Aeronave.Domain.Repositories;

namespace Aeronave.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IVueloService, VueloService>();
            services.AddTransient<IVueloFactory, VueloFactory>();
            services.AddTransient<IAeronaveFactory, AeronaveFactory>();
            return services;
        }
    }
}