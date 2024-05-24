using FastEndpoints;
using MediatR;
using Microsoft.AspNetCore.Routing;
using OneOfAKindSupreme.Backend.UseCases.Projects.Queries.Get;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class GetById(IMediator mediator) : Endpoint<GetProjectByIdRequest, GetByIdResponse>
    {
        public override void Configure()
        {
            Get(GetProjectByIdRequest.Route);
            AllowAnonymous();
        }

        public override async Task HandleAsync(GetProjectByIdRequest request, CancellationToken cancellationToken) 
        {
            var query = new GetProjectQuery(request.ProjectId);

            var result = await mediator.Send(query, cancellationToken);

            if(result != null)
            {
                var projectRecord = new ProjectRecord(result.Id, result.Name, result.Status.ToString());
                var response = new GetByIdResponse(projectRecord, [], true, GetLinksForProject(result.Id));
                Response = response;
            }
        }

        private IList<Core.Entities.HypermediaLink> GetLinksForProject(Guid projectId)
        {
            var host = HttpContext.Request.Host;
            var path = HttpContext.Request.Path;
            var scheme = HttpContext.Request.Scheme;

            var links = new List<Core.Entities.HypermediaLink>
            {
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}", "self", "GET"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}/projects", "list-projects", "GET"),                
                new Core.Entities.HypermediaLink($"{scheme}://{host}/projects", "create-project", "POST"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}", "update-project", "PUT"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}", "delete-project", "DELETE")
            };
            return links;
        }
    }
}
