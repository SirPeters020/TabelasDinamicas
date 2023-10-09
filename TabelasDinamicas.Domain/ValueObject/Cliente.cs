using TabelasDinamicas.Core.DomainObjects;

namespace TabelasDinamicas.Domain.ValueObject
{
    public class Cliente
    {
        public string? ClienteId { get; private set; }
        public string? Nome { get; private set; }
        public string? Codigo { get; private set; }
        public string? Email { get; private set; }

        public Cliente() { }

        public Cliente(string? clienteId, string nome, string codigo, string perfil, string email)
        {
            ClienteId = clienteId;
            Nome = nome;
            Codigo = codigo;
            Email = email;

            Validacoes.ValidarSeVazio(nome, "O campo Nome de Cliente não pode estar vazio");
            Validacoes.ValidarSeVazio(codigo, "O campo Codigo de cliente não pode estar vazio");
            Validacoes.ValidarSeVazio(email, "O campo Email de cliente não pode estar vazio");
        }
    }
}
