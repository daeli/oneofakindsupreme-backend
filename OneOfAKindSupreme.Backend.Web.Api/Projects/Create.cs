using FastEndpoints;
using MediatR;
using OneOfAKindSupreme.Backend.Core.Extensions;
using OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Create;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{    
    public class Create(IMediator mediator, LinkGenerator linkGenerator) : Endpoint<CreateProjectRequest, CreateProjectResponse>
    {
        public override void Configure()
        {
            Post(CreateProjectRequest.Route);
            
            AllowAnonymous();
        }

        public override async Task HandleAsync(CreateProjectRequest request, CancellationToken cancellationToken)
        {
            var result = await mediator.Send(new CreateProjectCommand(request.Name, request.Status.ToProjectStatus()), cancellationToken);
            
            if (result != Guid.Empty) 
            {
                var response = new CreateProjectResponse(result, request.Name, request.Status!, [], true, GetLinksForProject(result));                
                Response = response;
            }
        }

        private IList<Core.Entities.HypermediaLink> GetLinksForProject(Guid projectId) 
        {
            var uri = linkGenerator.GetUriByName(HttpContext, "OneOfAKindSupremeBackendWebApiProjectsCreate");            
            var links = new List<Core.Entities.HypermediaLink>
            {
                new Core.Entities.HypermediaLink(uri!, "self", "POST"),
                new Core.Entities.HypermediaLink(uri!, "list-projects", "GET"),
                new Core.Entities.HypermediaLink($"{uri}/{projectId}", "get-project", "GET"),
                new Core.Entities.HypermediaLink($"{uri}/{projectId}", "update-project", "PUT"),
                new Core.Entities.HypermediaLink($"{uri}/{projectId}", "delete-project", "DELETE")
            };
            return links;            
        }
    }
}
