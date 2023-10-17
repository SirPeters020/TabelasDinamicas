using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data.Mapping
{
    public class RegistroMap : IEntityTypeConfiguration<Registros>
    {
        public void Configure(EntityTypeBuilder<Registros> builder)
        {
            builder.ToTable("registros", "tabelas_dinamicas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TabelaId).IsRequired();

            builder.Property(x => x.ComplementoId).IsRequired();

            builder.Property(x => x.StatusId).IsRequired();

            builder.Property(x => x.Observacoes);

            builder.Property(x => x.DataAtualizacao);

            builder.OwnsOne(r => r.Cliente, cli =>
            {
                cli.Property(x => x.ClienteId)
                .HasColumnName("ClienteId");

                cli.Property(x => x.Nome)
                .HasColumnName("NomeCliente");

                cli.Property(x => x.Codigo)
                .HasColumnName("CodigoCliente");

                cli.Property(x => x.Email)
                .HasColumnName("EmailCliente");
            });

        }
    }
}
