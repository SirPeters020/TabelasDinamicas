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
    public class ComplementoRepository : IComplementoRepository
    {
        private readonly TabelasDinamicasContext _context;
        private readonly DbSet<Complemento> _complemento;

        public ComplementoRepository(TabelasDinamicasContext context)
        {
            _context = context;
            _complemento = _context.Set<Complemento>();
        }

        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public void Add(ComplementoTabela item)
        {
            throw new NotImplementedException();
        }

        public Task AddAsync(ComplementoTabela item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<ComplementoTabela> items)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<ComplementoTabela> items, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Delete(object key)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expression<Func<ComplementoTabela, bool>> where)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(object key, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Expression<Func<ComplementoTabela, bool>> where, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void Update(ComplementoTabela item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ComplementoTabela item, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public void UpdateRange(IEnumerable<ComplementoTabela> items)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(IEnumerable<ComplementoTabela> items, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
