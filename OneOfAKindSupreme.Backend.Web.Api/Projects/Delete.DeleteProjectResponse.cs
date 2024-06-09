using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.Core.Interfaces.Api;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class DeleteProjectResponse : IResponse<ProjectRecord>
    {
        private readonly ProjectRecord? project;
        private readonly List<string> errors = [];
        private readonly bool succeeded;
        private readonly IList<HypermediaLink>? hypermediaLinks;

        public DeleteProjectResponse(ProjectRecord? project, IList<string> errors, bool succeeded, IList<HypermediaLink>? hypermediaLinks)
        {
            if (errors is not null && errors.Count > 0) this.errors.AddRange(errors);

            this.succeeded = succeeded;
            this.hypermediaLinks = hypermediaLinks;
            this.project = project;
        }
        public bool Succeeded => succeeded;

        public IList<string>? Errors => errors;

        public ProjectRecord? Data => project;

        public IList<HypermediaLink>? Links => hypermediaLinks;
    }
}
