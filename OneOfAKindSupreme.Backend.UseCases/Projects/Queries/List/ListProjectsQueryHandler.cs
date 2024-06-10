using MediatR;
using OneOfAKindSupreme.Backend.Core.Domain.Models;
using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.Core.Interfaces.Repository;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Queries.List
{
    public class ListProjectsQueryHandler : IRequestHandler<ListProjectsQuery, Result<IList<Project>>>
    {
        IReadRepository<Project> repository;
        public ListProjectsQueryHandler(IReadRepository<Project> repository) 
        { 
            this.repository = repository;
        }

        public async Task<Result<IList<Project>>> Handle(ListProjectsQuery request, CancellationToken cancellationToken)
        {
            
            try
            {
                var list = await repository.ListAsync(cancellationToken);
                return new Result<IList<Project>>(true, null, list);
            }
            catch (Exception ex)
            {
                return new Result<IList<Project>>(false, new Error($"{ex.Message}"), []);
            }            
        }
    }
}
