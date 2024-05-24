using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.Core.Extensions;
using OneOfAKindSupreme.Backend.Core.Interfaces.Api;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class CreateProjectResponse : IResponse<Project>
    {
        private readonly Project project;
        private readonly List<string> errors = [];
        private readonly bool succeeded;
        private readonly IList<HypermediaLink>? hypermediaLinks;
        public CreateProjectResponse(Guid id, string name, string status, IList<string> errors, bool succeeded, IList<HypermediaLink>? hypermediaLinks)
        {
            project = new Project
            {
                Name = name,
                Id = id,
                Status = status.ToProjectStatus()
            };
            if (errors is not null && errors.Count > 0) this.errors.AddRange(errors);

            this.succeeded = succeeded;
           this.hypermediaLinks = hypermediaLinks;
        }
        public bool Succeeded => succeeded;
        public IList<string>? Errors => errors;
        public Project? Data => project;
        public IList<HypermediaLink>? Links => hypermediaLinks;
    }
}