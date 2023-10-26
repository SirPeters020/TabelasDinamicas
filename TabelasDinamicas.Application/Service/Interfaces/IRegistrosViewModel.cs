using TabelasDinamicas.Application.ViewModel;

namespace TabelasDinamicas.Application.Service.Interfaces
{
    public interface IRegistrosViewModel
    {
        Task<RegistrosViewModel> Get(Guid id);

        Task<IEnumerable<RegistrosViewModel>> Get();

        Task Add(RegistroPostViewModel model);

        Task Delete(Guid id);

        Task Update(RegistroPostViewModel model);
    }
}
