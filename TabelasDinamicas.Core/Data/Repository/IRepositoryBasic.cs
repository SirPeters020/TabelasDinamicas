using System.Linq.Expressions;
using TabelasDinamicas.Core.Domain;

namespace TabelasDinamicas.Core.Data.Repository
{
    public interface IRepositoryBasic<T> where T : EntityBase
    {
        IUnitOfWork UnitOfWork { get; }

        void Add(T item);

        Task AddAsync(T item, CancellationToken cancellationToken = default);

        void AddRange(IEnumerable<T> items);

        Task AddRangeAsync(IEnumerable<T> items, CancellationToken cancellationToken = default);

        void Delete(object key);

        void Delete(Expression<Func<T, bool>> where);

        Task DeleteAsync(object key, CancellationToken cancellationToken = default);

        void Update(T item);

        Task UpdateAsync(T item, CancellationToken cancellationToken = default);

        void UpdateRange(IEnumerable<T> items);

        Task UpdateRangeAsync(IEnumerable<T> items, CancellationToken cancellationToken = default);

        IEnumerable<T> Get();

        T Get(Guid id);

        Task<T> GetAsync(Guid id);

        Task<IEnumerable<T>> GetAsync();

    }
}
