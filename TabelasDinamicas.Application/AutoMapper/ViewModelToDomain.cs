using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabelasDinamicas.Application.ViewModel;
using TabelasDinamicas.Domain.Model;

namespace TabelasDinamicas.Application.AutoMapper;

public class ViewModelToDomain : Profile
{
    public ViewModelToDomain()
    {
        CreateMap<EstrategiaViewModel, Estrategia>();

        CreateMap<EstrategiaPostViewModel, Estrategia>();


        
    }
}
