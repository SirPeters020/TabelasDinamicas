using System.Linq.Expressions;
using TabelasDinamicas.Core.Domain;

namespace TabelasDinamicas.Core.Data.Repository;

public class RepositoryBasic<T> : IRepositoryBasic<T> where T : class, EntityBase
{
    public IUnitOfWork UnitOfWork => throw new NotImplementedException();

    public void Add(T item)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(T item, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void AddRange(IEnumerable<T> items)
    {
        throw new NotImplementedException();
    }

    public Task AddRangeAsync(IEnumerable<T> items, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Delete(object key)
    {
        throw new NotImplementedException();
    }

    public void Delete(Expression<Func<T, bool>> where)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(object key, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Expression<Func<T, bool>> where, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void Update(T item)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(T item, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public void UpdateRange(IEnumerable<T> items)
    {
        throw new NotImplementedException();
    }

    public Task UpdateRangeAsync(IEnumerable<T> items, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}