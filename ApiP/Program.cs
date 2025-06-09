using ApiProject.Extensions;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());
// Configurar CORS (asegúrate de tener la extensión creada)
builder.Services.ConfigureCors();
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "ApiP",
        Version = "v1",
        Description = "API de ejemplo usando MySQL y EF Core"
    });
});

// Configurar DbContext con MySQL
var connectionString = builder.Configuration.GetConnectionString("ConexMySql");
if (string.IsNullOrWhiteSpace(connectionString))
    throw new InvalidOperationException("La cadena de conexión 'ConexMySql' no está configurada.");

builder.Services.AddDbContext<PublicDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking); // Opcional
});

// Health checks (opcional)
builder.Services.AddHealthChecks();

// Agregar soporte para controladores
builder.Services.AddControllers();

var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiP v1");
        options.RoutePrefix = string.Empty; // Swagger en la raíz
    });
}

app.UseHttpsRedirection();
app.UseCors("CorsPolicy");

app.MapHealthChecks("/health");
app.MapControllers(); // Habilita controladores

app.Run();
