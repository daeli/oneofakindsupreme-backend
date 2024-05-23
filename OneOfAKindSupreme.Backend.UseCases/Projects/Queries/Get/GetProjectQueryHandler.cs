using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.Core.Interfaces.Repository;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Queries.Get
{
    public class GetProjectQueryHandler : IRequestHandler<GetProjectQuery, Project?>
    {
        private IReadRepository<Project> repository;
        public GetProjectQueryHandler(IReadRepository<Project> repository) 
        {
            this.repository = repository;
        }

        public async Task<Project?> Handle(GetProjectQuery request, CancellationToken cancellationToken)
        {
            return await repository.GetByIdAsync(request.Id, cancellationToken);
        }
    }
}
