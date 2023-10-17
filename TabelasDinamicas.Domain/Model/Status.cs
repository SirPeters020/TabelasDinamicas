using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelasDinamicas.Core.DomainObjects;

namespace TabelasDinamicas.Domain.Model
{
    public class Status : Entity
    {
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }

        public Status(string nome)
        {
            Nome = nome;
            Ativo = true;

            Validar();
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "Campo Nome não pode ser vazio");
        }
    }
}
