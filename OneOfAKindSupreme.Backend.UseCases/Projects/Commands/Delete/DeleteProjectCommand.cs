using MediatR;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Delete
{
    public class DeleteProjectCommand : IRequest
    {   
        private readonly Guid id;
        public DeleteProjectCommand(Guid id) 
        {
            this.id = id;
        }
        public Guid Id {  get { return id; } }
    }
}
