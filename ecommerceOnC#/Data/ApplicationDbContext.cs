using Microsoft.EntityFrameworkCore;
using ECommerce.Core.Models;

namespace ECommerce.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext // Contexto de la base de datos para la aplicación
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { } 
        // Constructor que recibe opciones de configuración

        public DbSet<Product> Products { get; set; } = default!;
    }
}