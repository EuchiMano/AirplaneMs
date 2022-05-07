using Aeronave.Application.Dto.Aeronave;
using MediatR;

namespace Aeronave.Application.UseCases.Queries.Aeronaves.GetAeronaveById
{
    public class GetAeronaveByIdQuery : IRequest<AeronaveDto>
    {
        public Guid Id { get; set; }
        public GetAeronaveByIdQuery(Guid id)
        {
            Id = id;
        }
        public GetAeronaveByIdQuery() { }
    }
}