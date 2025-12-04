using ECommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// === PASO 1: Registrar servicios ===
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer(); // Requerido para Swagger
builder.Services.AddSwaggerGen(); // Genera la documentación

// Agregar DbContext (mover aquí, antes de app.Build())
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// === PASO 2: Configurar el pipeline HTTP ===
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Habilita el endpoint /swagger/v1/swagger.json
    app.UseSwaggerUI(); // Interfaz web en /swagger
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();