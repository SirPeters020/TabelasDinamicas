using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using TabelasDinamicas.Core.Data.Repository;
using TabelasDinamicas.Domain.Interfaces;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Data.Repository
{
    public class StatusRepository : RepositoryBasic<Status>, IStatusRepository
    {
        private readonly TabelasDinamicasContext _context;
        private readonly DbSet<Status> _status;

        public StatusRepository(TabelasDinamicasContext context)
        {
            _context = context;
            _status = _context.Set<Status>();
        }

    }
}
