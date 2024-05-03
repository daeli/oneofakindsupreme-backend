using MediatR;
using FastEndpoints;
using OneOfAKindSupreme.Backend.UseCases.Projects.Queries.List;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class List(IMediator mediator) : EndpointWithoutRequest<ProjectListResponse>
    {
        public override void Configure() 
        {
            Get("/Projects");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken cancellationToken) 
        {
            var result = await mediator.Send(new ListProjectsQuery(), cancellationToken);

            if(result != null) 
            {
                Response = new ProjectListResponse
                {
                    Projects = result.Select(p => new ProjectRecord(p.Id, p.Name, p.Status.ToString())).ToList(),
                };
            }
        }
    }
}
