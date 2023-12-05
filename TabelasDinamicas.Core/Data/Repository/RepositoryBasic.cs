using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TabelasDinamicas.Core.Domain;

namespace TabelasDinamicas.Core.Data.Repository;

public class RepositoryBasic<T> : IRepositoryBasic<T> where T : class, EntityBase
{
    private readonly DbContext _context;
    public DbSet<T> _dbSet;

    public RepositoryBasic(DbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }


    public IUnitOfWork UnitOfWork => throw new NotImplementedException();

    public void Add(T item)
    {
        _dbSet.Add(item);
    }

    public async Task AddAsync(T item, CancellationToken cancellationToken = default)
    {
        _dbSet.AddAsync(item, cancellationToken);
    }

    public void AddRange(IEnumerable<T> items)
    {
        _dbSet.AddRange(items);
    }

    public async Task AddRangeAsync(IEnumerable<T> items, CancellationToken cancellationToken = default)
    {
        _dbSet.AddRangeAsync(items, cancellationToken);
    }

    public void Delete(object key)
    {
        var item = _dbSet.Find(key);

        if (item is null) return;

        _dbSet.Remove(item);
    }

    public void Delete(Expression<Func<T, bool>> where)
    {
        var items = _dbSet.Where(where);

        _dbSet.RemoveRange(items);
    }

    public async Task DeleteAsync(object key, CancellationToken cancellationToken = default)
    {
        var item = await _dbSet.FindAsync(key);

        if (item is null) return;

        _dbSet.Remove(item);
    }

    public IEnumerable<T> Get() => _dbSet.ToList();

    public T Get(Guid id) => _dbSet.Find(id);

    public async Task<T> GetAsync(Guid id) => await _dbSet.FindAsync(id);

    public async Task<IEnumerable<T>> GetAsync() => await _dbSet.ToListAsync();

    public void Update(T item)
    {
        _dbSet.Update(item);
    }

    public Task UpdateAsync(T item, CancellationToken cancellationToken = default)
    {
        return Task.Run(() => Update(item), cancellationToken);
    }

    public void UpdateRange(IEnumerable<T> items)
    {
        _dbSet.UpdateRange(items);
    }

    public Task UpdateRangeAsync(IEnumerable<T> items, CancellationToken cancellationToken = default)
    {
        return Task.Run(() => UpdateRange(items), cancellationToken);
    }
}