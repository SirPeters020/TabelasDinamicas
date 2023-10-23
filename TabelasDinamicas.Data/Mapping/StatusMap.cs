using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data.Mapping
{
    public class StatusMap : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("status", "tabelas_dinamicas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome).IsRequired();

            builder.Property(x => x.Ativo);

        }
    }
}
