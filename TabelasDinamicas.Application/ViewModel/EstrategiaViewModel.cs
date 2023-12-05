using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelasDinamicas.Application.ViewModel
{
    public class EstrategiaViewModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
    }

    public class EstrategiaPostViewModel
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Responsavel { get; set; }
    }
}
