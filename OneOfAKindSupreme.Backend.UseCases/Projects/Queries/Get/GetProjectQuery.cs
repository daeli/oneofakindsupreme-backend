using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Queries.Get
{
    public class GetProjectQuery : IRequest<Project?>
    {
        public GetProjectQuery(Guid id) { Id = id;  }
        public Guid Id { get; set; }
    }
}
