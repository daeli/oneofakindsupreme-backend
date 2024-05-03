using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.Core.Interfaces;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Update
{
    public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, Project>
    {
        IWriteRepository<Project> repository;
        public UpdateProjectCommandHandler(IWriteRepository<Project> repository)
        {
            this.repository = repository;
        }

        public async Task<Project> Handle(UpdateProjectCommand request, CancellationToken cancellationToken)
        {
            await repository.UpdateAsync(request.Project, cancellationToken);

            return request.Project;
        }
    }
}
