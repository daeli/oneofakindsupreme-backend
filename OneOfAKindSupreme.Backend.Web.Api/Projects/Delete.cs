using FastEndpoints;
using MediatR;
using OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Delete;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class Delete(IMediator mediator) : Endpoint<DeleteProjectRequest, DeleteProjectResponse>
    {
        public override void Configure()
        {
            Delete(DeleteProjectRequest.Route);
        }

        public override async Task HandleAsync(DeleteProjectRequest request, CancellationToken cancellationToken)
        {
            var query = new DeleteProjectCommand(request.ProjectId);

            await mediator.Send(query, cancellationToken);

            /*            if (result != null)
                        {                
                            var response = new DeleteProjectResponse(null, [], true, GetLinksForProject(request.ProjectId));
                            Response = response;
                        }*/
            var response = new DeleteProjectResponse(null, [], true, GetLinksForProject(request.ProjectId));
            Response = response;
        }

        private IList<Core.Entities.HypermediaLink> GetLinksForProject(Guid projectId)
        {            
            var host = HttpContext.Request.Host;
            var path = HttpContext.Request.Path;
            var scheme = HttpContext.Request.Scheme;
            var links = new List<Core.Entities.HypermediaLink>
            {
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}", "self", "POST"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}", "list-projects", "GET"),
                                new Core.Entities.HypermediaLink($"{scheme}://{host}/projects", "create-project", "POST"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}/{{projectId}}", "get-project", "GET"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}/{{projectId}}", "update-project", "PUT"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}/{{projectId}}", "delete-project", "DELETE")
            };
            return links;
        }
    }
}
