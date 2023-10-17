using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data.Mapping
{
    public class TabelaMap : IEntityTypeConfiguration<Tabela>
    {
        public void Configure(EntityTypeBuilder<Tabela> builder)
        {
            builder.ToTable("tabelas", "tabelas_dinamicas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome);

            builder.Property(x => x.Data);

            builder.Property(x => x.EstrategiaId).IsRequired();

            builder.Property(x => x.ValorMinimo);

            builder.Property(x => x.Ativa);

            builder.Property(x => x.Responsavel);

            builder.Property(x => x.Observacoes);

        }
    }
}
