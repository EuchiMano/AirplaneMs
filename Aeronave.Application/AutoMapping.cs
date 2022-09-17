using Aeronave.Application.Dto.Aeronave;
using Aeronave.Domain.Model.Aeronaves;
using AutoMapper;

namespace Aeronave.Application;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        CreateMap<List<AeronaveDto>, List<AeronaveModel>>();
    }
}