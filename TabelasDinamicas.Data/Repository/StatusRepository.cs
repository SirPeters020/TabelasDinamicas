using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TabelasDinamicas.Core.Data.Repository;
using TabelasDinamicas.Domain.Interfaces;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data.Repository
{
    public class StatusRepository : IStatusRepository
    {
        private readonly TabelasDinamicasContext _context;
        private readonly DbSet<Status> _status;

        public StatusRepository(TabelasDinamicasContext context)
        {
            _context = context;
            _status = _context.Set<Status>();
        }

        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public void Add(Status item)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(Status item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Status> items)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<Status> items, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Delete(object key)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<Status, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object key, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Expression<Func<Status, bool>> where, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Update(Status item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Status item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<Status> items)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<Status> items, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
