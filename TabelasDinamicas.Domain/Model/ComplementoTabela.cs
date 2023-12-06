using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelasDinamicas.Core.Domain;
using TabelasDinamicas.Core.DomainObjects;

namespace TabelasDinamicas.Domain.Model
{
    public class ComplementoTabela : Entity, EntityBase
    {

        public Guid TabelaId { get; private set; }
        public Guid ComplementoId { get; private set; }
        public int Ordenacao { get; private set; }
        public bool ComplementoVisivel { get; private set; }
        public bool BloquearFasesAnteriores { get; private set; }

        public Complemento Complemento { get; private set; }
        public Tabela Tabela { get; private set; }

    }
}
