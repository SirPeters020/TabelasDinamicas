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
    public class RegistroRepository : IRegistroRepository
    {
        private readonly TabelasDinamicasContext _context;
        private readonly DbSet<Registros> _registros;

        public RegistroRepository(TabelasDinamicasContext context)
        {
            _context = context;
            _registros = _context.Set<Registros>();
        }

        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public void Add(Registros item)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Registros item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Registros> items)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<Registros> items, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Delete(object key)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Registros, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object key, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Expression<Func<Registros, bool>> where, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Update(Registros item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Registros item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<Registros> items)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<Registros> items, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
