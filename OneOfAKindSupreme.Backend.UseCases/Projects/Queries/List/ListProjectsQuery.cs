using MediatR;
using OneOfAKindSupreme.Backend.Core.Domain.Models;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Queries.List
{
    public class ListProjectsQuery : IRequest<Result<IList<Project>>>
    {
    }
}
