using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelasDinamicas.Application.Service.Interfaces;
using TabelasDinamicas.Application.ViewModel;

namespace TabelasDinamicas.Application.Service
{
    public class TabelasService : ITabelasService
    {
        public Task Add(TabelasPostViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<TabelasViewModel> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TabelasViewModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task Update(TabelasPostViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
