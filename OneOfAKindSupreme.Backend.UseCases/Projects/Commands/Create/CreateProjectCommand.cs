using MediatR;
using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Create
{
    public class CreateProjectCommand : IRequest<int>
    {
        public required Project Project { get; set; }
    }
}
