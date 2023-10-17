using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data.Mapping
{
    public class ComplementoMap : IEntityTypeConfiguration<Complemento>
    {
        public void Configure(EntityTypeBuilder<Complemento> builder)
        {
            builder.ToTable("complementos", "tabelas_dinamicas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired();

            builder.Property(x => x.Tipo).IsRequired();

            builder.Property(x => x.OpcaoValor).IsRequired(false);

            builder.Property(x => x.PermitirVazio);

            builder.Property(x => x.PermiteAlteracao);

        }
    }
}
