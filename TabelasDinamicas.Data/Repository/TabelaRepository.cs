using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TabelasDinamicas.Core.Data.Repository;
using TabelasDinamicas.Domain.Interfaces;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data.Repository
{
    public class TabelaRepository : RepositoryBasic<Tabela>, ITabelaRepository
    {
        private readonly TabelasDinamicasContext _context;
        private readonly DbSet<Tabela> _tabelas;

        public TabelaRepository(TabelasDinamicasContext context)
        {
            _context = context;
            _tabelas = _context.Set<Tabela>();
        }

    }
}
