using MediatR;
using Microsoft.AspNetCore.Mvc;
using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.UseCases.Projects.Commands.Create;
using OneOfAKindSupreme.Backend.UseCases.Projects.Queries.Get;
using OneOfAKindSupreme.Backend.UseCases.Projects.Queries.List;
using OneOfAKindSupreme.Controllers;

namespace OneOfAKindSupreme.Backend.Web.Api.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProjectController : Controller
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator mediator;
        public ProjectController(ILogger<WeatherForecastController> logger, IMediator mediator)
        {
            _logger = logger;
            this.mediator = mediator;
        }

        [HttpGet(Name = "GetProject")]
        public async Task<Project?> Get(int id)
        {
            var result = await mediator.Send(new GetProjectQuery() { Id = id });

            return result;
        }

        [HttpGet(Name = "ListProjects")]
        public async Task<List<Project>> List()
        {
            var result = await mediator.Send(new ListProjectsQuery());

            return result.ToList();
        }

        [HttpPost(Name = "CreateProject")]
        public async Task<int> Create(Project project) 
        {
            var result = await mediator.Send(new CreateProjectCommand() { Project = project });

            return result;
        }  

    }
}
