using FastEndpoints;
using MediatR;
using Microsoft.AspNetCore.Routing;
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
                Response = new UpdateProjectResponse(projectRecord, [], true, GetLinksForProject());
            }
        }

        private IList<Core.Entities.HypermediaLink> GetLinksForProject()
        {
            var host = HttpContext.Request.Host;
            var path = HttpContext.Request.Path;
            var scheme = HttpContext.Request.Scheme;
            var links = new List<Core.Entities.HypermediaLink>
            {
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}", "self", "PUT"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}/projects", "list-projects", "GET"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}", "get-project", "GET"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}/projects", "create-project", "POST"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}", "delete-project", "DELETE")
            };
            return links;
        }
    }
}
