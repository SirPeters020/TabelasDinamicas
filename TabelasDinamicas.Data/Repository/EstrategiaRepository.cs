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
    public class EstrategiaRepository : IEstrategiaRepository
    {
        private readonly TabelasDinamicasContext _context;
        private readonly DbSet<Estrategia> _estrategias;

        public EstrategiaRepository(TabelasDinamicasContext context)
        {
            _context = context;
            _estrategias = _context.Set<Estrategia>();
        }

        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public void Add(Estrategia item)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Estrategia item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Estrategia> items)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<Estrategia> items, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Delete(object key)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Estrategia, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object key, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Expression<Func<Estrategia, bool>> where, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Update(Estrategia item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Estrategia item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<Estrategia> items)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<Estrategia> items, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
