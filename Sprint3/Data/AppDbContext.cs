using Microsoft.EntityFrameworkCore;

namespace OracleEfCoreExample
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Ajuste sua connection string
                optionsBuilder.UseOracle(
                    "User Id=rm93445;Password=130803;Data Source=oracle.fiap.com.br:1521/ORCL;"
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("TESTE"); // Nome da tabela no Oracle

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("ID");
                entity.Property(e => e.Nome).HasColumnName("NOME").HasMaxLength(100).IsRequired();
                entity.Property(e => e.Xp).HasColumnName("XP");
                entity.Property(e => e.TasksConcluidas).HasColumnName("TASKSCONCLUIDAS");
            });
        }
    }
}
