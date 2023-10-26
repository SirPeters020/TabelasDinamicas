using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelasDinamicas.Application.Service.Interfaces;
using TabelasDinamicas.Application.ViewModel;

namespace TabelasDinamicas.Application.Service
{
    public class EstrategiaService : IEstrategiaService
    {
        public Task Add(EstrategiaPostViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<EstrategiaViewModel> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<EstrategiaViewModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task Update(EstrategiaPostViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
