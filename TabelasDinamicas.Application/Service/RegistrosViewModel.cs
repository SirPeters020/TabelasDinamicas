﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelasDinamicas.Application.Service.Interfaces;
using TabelasDinamicas.Application.ViewModel;
using TabelasDinamicas.Domain.Interfaces;

namespace TabelasDinamicas.Application.Service
{
    public class RegistrosViewModel : IRegistrosViewModel
    {

        private readonly IRegistroRepository _repository;

        public RegistrosViewModel(IRegistroRepository repository)
        {
            _repository = repository;
        }

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
