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
    public class EstrategiaRepository : RepositoryBasic<Estrategia>, IEstrategiaRepository
    {
        private readonly TabelasDinamicasContext _context;
        private readonly DbSet<Estrategia> _estrategias;

        public EstrategiaRepository(TabelasDinamicasContext context)
        {
            _context = context;
            _estrategias = _context.Set<Estrategia>();
        }

    }
}
