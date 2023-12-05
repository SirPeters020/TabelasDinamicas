using TabelasDinamicas.Application.ViewModel;

namespace TabelasDinamicas.Application.Service.Interfaces
{
    public interface IEstrategiaService
    {
        Task<EstrategiaViewModel> Get(Guid id);

        Task<IEnumerable<EstrategiaViewModel>> Get();

        Task Add(EstrategiaPostViewModel model);

        Task Delete(Guid id);

        Task Update(EstrategiaPostViewModel model, Guid id);
    }
}
