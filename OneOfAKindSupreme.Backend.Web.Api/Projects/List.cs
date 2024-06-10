using MediatR;
using FastEndpoints;
using OneOfAKindSupreme.Backend.UseCases.Projects.Queries.List;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class List(IMediator mediator) : EndpointWithoutRequest<ProjectListResponse>
    {
        public override void Configure() 
        {
            Get("/projects");           
        }

        public override async Task HandleAsync(CancellationToken cancellationToken) 
        {
            var result = await mediator.Send(new ListProjectsQuery(), cancellationToken);

            if(result.IsSuccessful) 
            {
                var projects = result?.Data?.Select(p => new ProjectRecord(p.Id, p.Name, p.Status.ToString())).ToList();
                var response = new ProjectListResponse(projects, [], true, GetLinksForProject());
                Response = response;
            }
        }

        private IList<Core.Entities.HypermediaLink> GetLinksForProject()
        {
            var host = HttpContext.Request.Host;
            var path = HttpContext.Request.Path;
            var scheme = HttpContext.Request.Scheme;

            var links = new List<Core.Entities.HypermediaLink>
            {
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}", "self", "GET"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}/project/{{project-id}}", "get-project", "GET"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}/projects", "create-project", "POST"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}/{{project-id}}", "update-project", "PUT"),
                new Core.Entities.HypermediaLink($"{scheme}://{host}{path}/{{project-id}}", "delete-project", "DELETE")
            };
            return links;
        }
    }
}
