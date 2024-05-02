using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Queries.Get
{
    public class GetProjectQuery : IRequest<Project?>
    {
        public required int Id { get; set; }
    }
}
