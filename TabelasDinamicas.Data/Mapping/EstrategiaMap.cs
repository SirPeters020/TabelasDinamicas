using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data.Mapping
{
    public class EstrategiaMap : IEntityTypeConfiguration<Estrategia>
    {
        public void Configure(EntityTypeBuilder<Estrategia> builder)
        {
            builder.ToTable("estrategias", "tabelas_dinamicas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome);

            builder.Property(x => x.Descricao);

            builder.Property(x => x.Responsavel);

        }
    }
}
