using TabelasDinamicas.Core.Domain;
using TabelasDinamicas.Core.DomainObjects;
using TabelasDinamicas.Domain.ValueObject;

namespace TabelasDinamicas.Domain.Model;

public class Registros : Entity, EntityBase
{

    #region [ Propriedades ]

    public Guid TabelaId { get; private set; }

    public Guid ComplementoId { get; private set; }

    public Guid StatusId { get; private set; }

    public Cliente? Cliente { get; private set; }

    public Usuario Responsavel { get; private set; }

    public QuantidadeValor? Quantidade { get; private set; }

    public string Observacoes { get; private set; }

    public DateTime? DataAtualizacao { get; private set; }

    public Complemento Complemento { get; private set; }

    public Tabela Tabela { get; private set; }

    public Status Status { get; private set; }

    public List<ComplementoRegistro> ComplementoRegistro { get; private set; }

    #endregion

}
