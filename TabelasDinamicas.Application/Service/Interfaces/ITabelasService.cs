using TabelasDinamicas.Application.ViewModel;

namespace TabelasDinamicas.Application.Service.Interfaces
{
    public interface ITabelasService
    {
        Task<TabelasViewModel> Get(Guid id);

        Task<IEnumerable<TabelasViewModel>> Get();

        Task Add(TabelasPostViewModel model);

        Task Delete(Guid id);

        Task Update(TabelasPostViewModel model);
    }
}
