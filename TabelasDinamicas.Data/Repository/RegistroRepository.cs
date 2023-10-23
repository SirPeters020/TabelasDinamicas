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
    public class RegistroRepository : RepositoryBasic<Registros>, IRegistroRepository
    {
        private readonly TabelasDinamicasContext _context;
        private readonly DbSet<Registros> _registros;

        public RegistroRepository(TabelasDinamicasContext context)
        {
            _context = context;
            _registros = _context.Set<Registros>();
        }

    }
}
