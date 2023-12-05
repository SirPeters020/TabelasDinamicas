using TabelasDinamicas.Application.ViewModel;

namespace TabelasDinamicas.Application.Service.Interfaces
{
    public interface IRegistrosService
    {
        Task<RegistrosService> Get(Guid id);

        Task<IEnumerable<RegistrosService>> Get();

        Task Add(RegistroPostViewModel model);

        Task Delete(Guid id);

        Task Update(RegistroPostViewModel model, Guid id);
    }
}
