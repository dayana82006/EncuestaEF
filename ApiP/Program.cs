using ApiProject.Extensions;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());

builder.Services.ConfigureCors();
builder.Services.AddControllers();
builder.Services.AddCustomRateLimiter();

// Configurar DbContext con MySQL
var connectionString = builder.Configuration.GetConnectionString("ConexMySql");
if (string.IsNullOrWhiteSpace(connectionString))
    throw new InvalidOperationException("La cadena de conexión 'ConexMySql' no está configurada.");

builder.Services.AddDbContext<PublicDbContext>(options =>
{
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking); 
});

builder.Services.AddHealthChecks();
builder.Services.AddControllers();
var app = builder.Build();
app.UseRateLimiter();

app.UseAuthorization();
app.UseAuthentication();
app.UseHttpsRedirection();
app.UseCors("CorsPolicy");
app.MapHealthChecks("/health");
app.MapControllers(); 
app.Run();
