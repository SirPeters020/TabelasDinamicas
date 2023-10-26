using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelasDinamicas.Application.Service.Interfaces;
using TabelasDinamicas.Application.ViewModel;

namespace TabelasDinamicas.Application.Service
{
    public class RegistrosViewModel : IRegistrosViewModel
    {
        public Task Add(RegistroPostViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<RegistrosViewModel> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RegistrosViewModel>> Get()
        {
            throw new NotImplementedException();
        }

        public Task Update(RegistroPostViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
