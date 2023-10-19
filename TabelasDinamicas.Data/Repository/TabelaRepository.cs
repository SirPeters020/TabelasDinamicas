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
    public class TabelaRepository : ITabelaRepository
    {
        private readonly TabelasDinamicasContext _context;
        private readonly DbSet<Tabela> _tabelas;

        public TabelaRepository(TabelasDinamicasContext context)
        {
            _context = context;
            _tabelas = _context.Set<Tabela>();
        }

        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public void Add(Tabela item)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Tabela item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Tabela> items)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<Tabela> items, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Delete(object key)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Tabela, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object key, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Expression<Func<Tabela, bool>> where, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Update(Tabela item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Tabela item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<Tabela> items)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<Tabela> items, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
