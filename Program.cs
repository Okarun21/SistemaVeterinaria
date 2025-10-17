using LiteDB;
using Modelo_Veterinaria.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton(new LiteDatabase("veterinaria.db"));
builder.Services.AddScoped<VeterinarioService>();
builder.Services.AddScoped<ServicioMedicoService>();
builder.Services.AddScoped<RegistroClinicoService>();
builder.Services.AddScoped<HistorialClinicoService>();
builder.Services.AddScoped<EspecialidadService>();
builder.Services.AddScoped<PerroService>();
builder.Services.AddScoped<GatoService>();
builder.Services.AddControllers();
var app = builder.Build();
app.MapControllers();
app.Run();