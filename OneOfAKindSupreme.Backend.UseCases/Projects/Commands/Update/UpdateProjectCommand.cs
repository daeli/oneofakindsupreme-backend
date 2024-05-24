using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Update
{
    public class UpdateProjectCommand : IRequest<Project> 
    {
        public UpdateProjectCommand(Guid id, string Name, ProjectStatus status) 
        {
            Project = new Project { Id = id, Name = Name, Status = status };
        }
        public Project Project { get; set; }
    }
}
