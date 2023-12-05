using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data.Mapping
{
    public class ComplementoRegistroMap : IEntityTypeConfiguration<ComplementoRegistro>
    {
        public void Configure(EntityTypeBuilder<ComplementoRegistro> builder)
        {
            builder.ToTable("complemento_registro", "tabelas_dinamicas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor).HasMaxLength(50).IsRequired();

            builder.Property(x => x.Atual);

            builder.Ignore(x => x.Nova);

            builder.HasOne(x => x.Registro)
                .WithMany(c => c.ComplementoRegistro)
                .HasForeignKey(x => x.RegistroId);

            builder.HasOne(x => x.Complemento)
                .WithMany(c => c.ComplementoRegistro)
                .HasForeignKey(x => x.ComplementoId);

        }
    }
}
