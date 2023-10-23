using Microsoft.EntityFrameworkCore;
using TabelasDinamicas.Core.Data.Repository;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data
{
    public class TabelasDinamicasContext : DbContext, IUnitOfWork
    {
        public TabelasDinamicasContext
        (
            DbSet<Complemento> complemento,
            DbSet<ComplementoRegistro> complementoRegistro,
            DbSet<ComplementoTabela> complementoTabela,
            DbSet<Estrategia> estrategia, 
            DbSet<Registros> registros, 
            DbSet<Status> status, 
            DbSet<Tabela> tabela
        )
        {
            Complemento = complemento;
            ComplementoRegistro = complementoRegistro;
            ComplementoTabela = complementoTabela;
            Estrategia = estrategia;
            Registros = registros;
            Status = status;
            Tabela = tabela;
        }

        public DbSet<Complemento> Complemento { get; set; }
        public DbSet<ComplementoRegistro> ComplementoRegistro { get; set; }
        public DbSet<ComplementoTabela> ComplementoTabela { get; set; }
        public DbSet<Estrategia> Estrategia { get; set; }
        public DbSet<Registros> Registros { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Tabela> Tabela { get; set; }


        public async Task<bool> CommitAsync()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added) entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified) entry.Property("DataCadastro").IsModified = false;
            }

            var sucesso = await base.SaveChangesAsync() > 0;

            return sucesso;
        }

        public bool Commit()
        {
            var sucesso = base.SaveChanges() > 0;

            return sucesso;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TabelasDinamicasContext).Assembly);
        }
    }
}
