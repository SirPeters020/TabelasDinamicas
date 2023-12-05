using TabelasDinamicas.Core.Domain;
using TabelasDinamicas.Core.DomainObjects;

namespace TabelasDinamicas.Domain.Model;

public class Complemento : Entity, EntityBase
{
    public string Nome { get; private set; }

    public string Tipo { get; private set; }

    public string OpcaoValor { get; private set; }

    public bool PermitirVazio { get; private set; }

    public bool PermiteAlteracao { get; private set; }

    private readonly List<ComplementoRegistro> _complementoRegistro;
    public IReadOnlyCollection<ComplementoRegistro> ComplementoRegistro => _complementoRegistro;

    private readonly List<ComplementoTabela> _complementoTabela;
    public IReadOnlyCollection<ComplementoTabela> ComplementoTabela => _complementoTabela;

    public Complemento() { }

    public Complemento(string nome, string tipo, string opcaoValor, bool permitirVazio, bool permiteAlteracao)
    {
        Nome = nome;
        Tipo = tipo;
        OpcaoValor = opcaoValor;
        PermitirVazio = permitirVazio;
        PermiteAlteracao = permiteAlteracao;
    }



}
