using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelasDinamicas.Application.ViewModel
{
    public class TabelasViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public DateTime Data { get; set; }

        public decimal ValorMinimo { get; set; }

        public bool Ativa { get; set; }

        public string Responsavel { get; set; }

        public string Observacoes { get; set; }

        public EstrategiaViewModel Estrategia { get; set; }
    }

    public class TabelasPostViewModel
    {
        public string Nome { get; set; }

        public DateTime Data { get; set; }

        public decimal ValorMinimo { get; set; }

        public bool Ativa { get; set; }

        public string Responsavel { get; set; }

        public string Observacoes { get; set; }

        public Guid EstrategiaId { get; set; }
    }


}
