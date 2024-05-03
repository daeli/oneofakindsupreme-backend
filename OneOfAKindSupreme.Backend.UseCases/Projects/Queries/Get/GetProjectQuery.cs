using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Queries.Get
{
    public class GetProjectQuery : IRequest<Project?>
    {
        public GetProjectQuery(int id) { Id = id;  }
        public int Id { get; set; }
    }
}
