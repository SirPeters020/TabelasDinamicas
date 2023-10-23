using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data.Mapping
{
    public class ComplementoTabelaMap : IEntityTypeConfiguration<ComplementoTabela>
    {
        public void Configure(EntityTypeBuilder<ComplementoTabela> builder)
        {
            builder.ToTable("complemento_tabelas", "tabelas_dinamicas");

            builder.HasKey(c => new { c.TabelaId, c.ComplementoId });

            builder.Property(c => c.Ordenacao);

            builder.HasOne(c => c.Complemento)
                .WithMany(c => c.ComplementoTabela)
                .HasForeignKey(c => c.ComplementoId);

            builder.HasOne(c => c.Tabela)
                .WithMany(c => c.ComplementoTabela)
                .HasForeignKey(c => c.TabelaId);
        }
    }
}
