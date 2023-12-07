using Microsoft.EntityFrameworkCore;
using ProyectoPerro.Data.Models;

namespace ProyectoPerro.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Perro> Perros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Collar> Collars { get; set; }
        public DbSet<Gps> Gpss { get; set; }




    }
}
