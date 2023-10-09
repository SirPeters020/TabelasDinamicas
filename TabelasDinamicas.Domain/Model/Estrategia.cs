using TabelasDinamicas.Core.DomainObjects;

namespace TabelasDinamicas.Domain.Model;

public class Estrategia : Entity
{

    public string Nome { get; private set; }
    public string Descricao { get; private set; }
    public string Responsavel { get; private set; }

    public Estrategia() { }

    public Estrategia(string nome, string descricao, string responsavel)
    {
        Nome = nome;
        Descricao = descricao;
        Responsavel = responsavel;
    }
}
