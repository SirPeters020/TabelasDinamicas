using AutoMapper;
using TabelasDinamicas.Application.Service.Interfaces;
using TabelasDinamicas.Application.ViewModel;
using TabelasDinamicas.Domain.Interfaces;
using TabelasDinamicas.Domain.Model;
using TabelasDinamicas.Domain.ValueObject;

namespace TabelasDinamicas.Application.Service;

public class RegistrosService : IRegistrosService
{

    private readonly IRegistroRepository _repository;
    private readonly IMapper _mapper;

    public RegistrosService(IRegistroRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task Add(RegistroPostViewModel model)
    {
        var tabela = _mapper.Map<Registros>(model);

        await _repository.AddAsync(tabela);

        await _repository.UnitOfWork.CommitAsync();
    }

    public async Task Delete(Guid id)
    {
        await _repository.DeleteAsync(id);

        await _repository.UnitOfWork.CommitAsync();
    }

    public async Task<RegistrosService> Get(Guid id)
    {
        var registro = await _repository.GetAsync(id);

        return _mapper.Map<RegistrosService>(registro);
    }

    public async Task<IEnumerable<RegistrosService>> Get()
    {
        var registros = await _repository.GetAsync();

        return _mapper.Map<IEnumerable<RegistrosService>>(registros);
    }

    public async Task Update(RegistroPostViewModel model, Guid id)
    {
        var registro = await _repository.GetAsync(id);

        registro.Update(new QuantidadeValor(model.Quantidade, model.Valor), model.Observacoes);

        await _repository.UpdateAsync(registro);

        await _repository.UnitOfWork.CommitAsync();
    }
}
