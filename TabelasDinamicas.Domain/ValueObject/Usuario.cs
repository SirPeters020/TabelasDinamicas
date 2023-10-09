using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelasDinamicas.Core.DomainObjects;

namespace TabelasDinamicas.Domain.ValueObject
{
    public class Usuario
    {
        public string Id { get; }
        public string Nome { get; }

        public Usuario(string id, string nome)
        {
            if (id == null || nome == null) return;

            Validacoes.ValidarSeVazio(nome, "O campo Nome não pode estar vazio");
            Validacoes.ValidarSeVazio(id, "O campo ID não pode estar vazio");

            Id = id;
            Nome = nome;
        }

        public Usuario() { }
    }
}
