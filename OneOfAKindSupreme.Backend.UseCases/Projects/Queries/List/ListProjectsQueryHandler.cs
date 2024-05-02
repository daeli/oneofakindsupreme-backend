using MediatR;
using OneOfAKindSupreme.Backend.Core.Interfaces;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Queries.List
{
    public class ListProjectsQueryHandler : IRequestHandler<ListProjectsQuery, List<Project>>
    {
        IReadRepository<Project> repository;
        public ListProjectsQueryHandler(IReadRepository<Project> repository) 
        { 
            this.repository = repository;
        }

        public async Task<List<Project>> Handle(ListProjectsQuery request, CancellationToken cancellationToken)
        {
            return await repository.ListAsync(cancellationToken);
        }
    }
}
