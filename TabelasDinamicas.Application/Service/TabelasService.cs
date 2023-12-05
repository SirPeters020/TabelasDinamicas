using AutoMapper;
using TabelasDinamicas.Application.Service.Interfaces;
using TabelasDinamicas.Application.ViewModel;
using TabelasDinamicas.Domain.Interfaces;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Application.Service;

public class TabelasService : ITabelasService
{
    private readonly ITabelaRepository _repository;
    private readonly IMapper _mapper;

    public TabelasService(ITabelaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task Add(TabelasPostViewModel model)
    {
        var tabela = _mapper.Map<Tabela>(model);

        await _repository.AddAsync(tabela);

        await _repository.UnitOfWork.CommitAsync();
    }

    public async Task Delete(Guid id)
    {
        await _repository.DeleteAsync(id);

        await _repository.UnitOfWork.CommitAsync();
    }

    public async Task<TabelasViewModel> Get(Guid id)
    {
        var tabela = await _repository.GetAsync(id);

        return _mapper.Map<TabelasViewModel>(tabela);
    }

    public async Task<IEnumerable<TabelasViewModel>> Get()
    {
        var tabela = await _repository.GetAsync();

        return _mapper.Map<IEnumerable<TabelasViewModel>>(tabela);
    }

    public async Task Update(TabelasPostViewModel model, Guid id)
    {
        var tabela = await _repository.GetAsync(id);

        tabela.UpdateTabela(model.Nome, model.EstrategiaId, model.ValorMinimo, model.Ativa, model.Observacoes);

        await _repository.UpdateAsync(tabela);

        await _repository.UnitOfWork.CommitAsync();
    }
}
