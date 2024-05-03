using FastEndpoints;
using MediatR;
using OneOfAKindSupreme.Backend.Core.Extensions;
using OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Update;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class Update(IMediator mediator)
  : Endpoint<UpdateProjectRequest, UpdateProjectResponse>
    {
        public override void Configure()
        {
            Put(UpdateProjectRequest.Route);
            AllowAnonymous();
        }

        public override async Task HandleAsync(UpdateProjectRequest request, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(new UpdateProjectCommand(request.Id, request.Name, request.Status.ToProjectStatus()), cancellationToken);

            if (result != null) 
            {
                var projectRecord = new ProjectRecord(result.Id, result.Name, result.Status.ToString());
                Response = new UpdateProjectResponse(projectRecord);
            }
        }
    }
}
