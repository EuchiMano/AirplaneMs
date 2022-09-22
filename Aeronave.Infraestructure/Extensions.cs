using Aeronave.Application;
using Aeronave.Application.UseCases.Consumers;
using Aeronave.Domain.Repositories;
using Aeronave.Infraestructure.EF;
using Aeronave.Infraestructure.EF.Context;
using Aeronave.Infraestructure.EF.Repository;
using MassTransit;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Aeronave.Infraestructure;

public static class Extensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddApplication();
        services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
        var connectionString = configuration.GetConnectionString("AeronaveDbConnectionString");

        services.AddDbContext<ReadDbContext>(context =>
            context.UseNpgsql(connectionString));
        services.AddDbContext<WriteDbContext>(context =>
            context.UseNpgsql(connectionString));

        services.AddScoped<IVueloRepository, VueloRepository>();
        services.AddScoped<IAeronaveRepository, AeronaveRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        AddRabbitMq(services, configuration);
        return services;
    }

    private static void AddRabbitMq(this IServiceCollection services, IConfiguration configuration)
    {
        var rabbitMqHost = configuration["RabbitMq:Host"];
        var rabbitMqPort = configuration["RabbitMq:Port"];
        var rabbitMqUserName = configuration["RabbitMq:UserName"];
        var rabbitMqPassword = configuration["RabbitMq:Password"];

        services.AddMassTransit(config =>
        {
            config.AddConsumer<VueloCreadoConsumer>()
                .Endpoint(endpoint => endpoint.Name = VueloCreadoConsumer.QueueName);
            config.AddConsumer<VueloConcluidoConsumer>()
                .Endpoint(endpoint => endpoint.Name = VueloConcluidoConsumer.QueueName);
            config.UsingRabbitMq((context, cfg) =>
            {
                var uri = string.Format("amqp://{0}:{1}@{2}:{3}", rabbitMqUserName, rabbitMqPassword, rabbitMqHost,
                    rabbitMqPort);
                cfg.Host(uri);

                cfg.ReceiveEndpoint(VueloCreadoConsumer.QueueName,
                    endpoint => { endpoint.ConfigureConsumer<VueloCreadoConsumer>(context); });

                cfg.ReceiveEndpoint(VueloConcluidoConsumer.QueueName,
                    endpoint => { endpoint.ConfigureConsumer<VueloConcluidoConsumer>(context); });
            });
        });
    }
}