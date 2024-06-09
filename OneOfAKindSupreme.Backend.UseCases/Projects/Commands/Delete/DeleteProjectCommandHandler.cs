using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.Core.Interfaces.Repository;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Delete
{
    public class DeleteProjectCommandHandler : IRequestHandler<DeleteProjectCommand>
    {
        IWriteRepository<Project> writeRepository;
        IReadRepository<Project> readRepository;
        public DeleteProjectCommandHandler(IWriteRepository<Project> writeRepository, IReadRepository<Project> readRepository)
        {
            this.writeRepository = writeRepository;
            this.readRepository = readRepository;
        }

        public async Task Handle(DeleteProjectCommand request, CancellationToken cancellationToken)
        {
            var project = await readRepository.GetByIdAsync(request.Id);
            await writeRepository.DeleteAsync(project, cancellationToken);
        }
    }
}
