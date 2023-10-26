using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelasDinamicas.Application.ViewModel
{
    public class RegistrosViewModel
    {
        public Guid TabelaId { get; set; }

        public string Tabela { get; set; }

        public string NomeCliente { get; set; }

        public string CodigoCliente { get; set; }

        public string Responsavel { get; set; }

        public string Quantidade { get; set; }
        public string Valor { get; set; }

        public string Observacoes { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public IEnumerable<ComplementoResumeViewModel> Complementos { get; set; }

        public Guid Id { get; set; }

        public string Status { get; set; }

    }


    public class RegistroPostViewModel
    {
        public Guid TabelaId { get; set; }

        public string Tabela { get; set; }

        public string NomeCliente { get; set; }

        public string CodigoCliente { get; set; }

        public string Responsavel { get; set; }
        public string ResponsavelId { get; set; }

        public string Quantidade { get; set; }
        public string Valor { get; set; }

        public string Observacoes { get; set; }

        public DateTime? DataAtualizacao { get; set; }

        public Guid StatusId { get; set; }
    }


}
