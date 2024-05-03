using FastEndpoints;
using MediatR;
using OneOfAKindSupreme.Backend.Core.Extensions;
using OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Create;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class Create(IMediator mediator) : Endpoint<CreateProjectRequest, CreateProjectResponse>
    {
        public override void Configure()
        {
            Post(CreateProjectRequest.Route);
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateProjectRequest request, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(new CreateProjectCommand(request.Name, request.Status.ToProjectStatus()), cancellationToken);

            if (result > 0) 
            {
                Response = new CreateProjectResponse(result, request.Name, request.Status!);
            }
        }
    }
}
