using FastEndpoints;
using MediatR;
using OneOfAKindSupreme.Backend.UseCases.Projects.Queries.Get;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class GetById(IMediator mediator) : Endpoint<GetProjectByIdRequest, ProjectRecord>
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
                Response = new ProjectRecord(result.Id, result.Name, result.Status.ToString());
            }
        }
    }
}
