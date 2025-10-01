using Microsoft.EntityFrameworkCore;
using ServicoAuxiliar.Models;

namespace ServicoAuxiliar.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        // Outros métodos e configurações...
    }
}