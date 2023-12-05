using AutoMapper;
using TabelasDinamicas.Application.ViewModel;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Application.AutoMapper;

public class DomainToViewModel : Profile
{
    public DomainToViewModel()
    {

        CreateMap<Estrategia, EstrategiaViewModel>();

        CreateMap<Registros, RegistrosViewModel>();

        CreateMap<Complemento, ComplementoResumeViewModel>();

    }
}
