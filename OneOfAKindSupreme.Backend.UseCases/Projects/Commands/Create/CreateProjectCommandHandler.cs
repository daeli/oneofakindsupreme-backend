using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.Core.Interfaces.Repository;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Create
{
    public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, Guid>
    {
        IWriteRepository<Project> repository;
        public CreateProjectCommandHandler(IWriteRepository<Project> repository) 
        {
            this.repository = repository;
        }

        public async Task<Guid> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
        {
            var addedEntity = await repository.AddAsync(request.Project, cancellationToken);

            return addedEntity.Id;
        }
    }
}
