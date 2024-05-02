using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Queries.List
{
    public class ListProjectsQuery : IRequest<List<Project>>
    {
    }
}
