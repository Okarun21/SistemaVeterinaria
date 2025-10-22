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
builder.Services.AddScoped<PersonaService>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); 
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Veterinaria API V1");
        c.RoutePrefix = string.Empty; 
    });
}
else
{
   
    app.UseExceptionHandler("/error"); 
    app.UseStatusCodePages();
}

app.MapControllers();

app.Run();
