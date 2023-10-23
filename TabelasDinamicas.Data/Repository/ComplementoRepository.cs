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
    public class ComplementoRepository : RepositoryBasic<Complemento>, IComplementoRepository
    {
        private readonly TabelasDinamicasContext _context;
        private readonly DbSet<Complemento> _complemento;

        public ComplementoRepository(TabelasDinamicasContext context)
        {
            _context = context;
            _complemento = _context.Set<Complemento>();
        }

    }
}
