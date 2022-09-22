using System.Reflection;
using Aeronave.Infraestructure;
using Aeronave.Infraestructure.EF.Context;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<WriteDbContext>();
    //if (context.Database.GetPendingMigrations().Any())
    //{
    //    context.Database.Migrate();
    //}
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();