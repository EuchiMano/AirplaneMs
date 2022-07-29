using Aeronave.Application;
using Aeronave.Domain.Repositories;
using Aeronave.Infraestructure.EF;
using Aeronave.Infraestructure.EF.Context;
using Aeronave.Infraestructure.EF.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Aeronave.Infraestructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddApplication();
            services.AddMediatR(Assembly.GetExecutingAssembly());
            var connectionString = configuration.GetConnectionString("AeronaveDbConnectionString");

            services.AddDbContext<ReadDbContext>(context =>
                context.UseNpgsql(connectionString));
            services.AddDbContext<WriteDbContext>(context =>
                context.UseNpgsql(connectionString));

            services.AddScoped<IVueloRepository, VueloRepository>();
            services.AddScoped<IAeronaveRepository, AeronaveRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}