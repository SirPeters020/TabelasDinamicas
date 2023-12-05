using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabelasDinamicas.Core.Data.Repository;

public interface IUnitOfWork
{
    Task<bool> CommitAsync();
    bool Commit();
}
