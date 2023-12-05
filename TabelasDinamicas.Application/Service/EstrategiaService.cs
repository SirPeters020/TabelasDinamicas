using AutoMapper;
using TabelasDinamicas.Application.Service.Interfaces;
using TabelasDinamicas.Application.ViewModel;
using TabelasDinamicas.Domain.Interfaces;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Application.Service
{
    public class EstrategiaService : IEstrategiaService
    {
        private readonly IEstrategiaRepository _repository;
        private readonly IMapper _mapper;

        public EstrategiaService(IEstrategiaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Add(EstrategiaPostViewModel model)
        {
            var estrategia = _mapper.Map<Estrategia>(model);

            await _repository.AddAsync(estrategia);

            await _repository.UnitOfWork.CommitAsync();
        }

        public async Task Delete(Guid id)
        {
            await _repository.DeleteAsync(id);

            await _repository.UnitOfWork.CommitAsync();
        }

        public async Task<EstrategiaViewModel> Get(Guid id)
        {
            var estrategia = await _repository.GetAsync(id);

            return _mapper.Map<EstrategiaViewModel>(estrategia);
        }

        public async Task<IEnumerable<EstrategiaViewModel>> Get()
        {
            var estrategias = await _repository.GetAsync();

            return _mapper.Map<IEnumerable<EstrategiaViewModel>>(estrategias);
        }

        public async Task Update(EstrategiaPostViewModel model, Guid id)
        {
            var estrategiaBase = await _repository.GetAsync(id);

            estrategiaBase.UpdateEstrategia(model.Nome, model.Descricao, model.Responsavel);

            await _repository.UpdateAsync(estrategiaBase);

            await _repository.UnitOfWork.CommitAsync();
        }
    }
}
