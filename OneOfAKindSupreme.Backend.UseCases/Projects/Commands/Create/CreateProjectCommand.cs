using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Create
{
    public class CreateProjectCommand : IRequest<int>
    {
        public CreateProjectCommand(string name, ProjectStatus status)
        {
            Project = new Project { Name = name, Status = status };
        }
        public Project Project { get; set; }
    }
}
