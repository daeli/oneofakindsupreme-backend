using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class ProjectListResponse
    {
        private readonly IList<ProjectRecord> projects = [];
        private readonly List<string> errors = [];
        private readonly bool succeeded;
        private readonly IList<HypermediaLink>? hypermediaLinks;

        public ProjectListResponse(IList<ProjectRecord> projectRecords, IList<string> errors, bool succeeded, IList<HypermediaLink>? hypermediaLinks)
        {
            this.projects = projectRecords;
            if (errors is not null && errors.Count > 0) this.errors.AddRange(errors);
            this.succeeded = succeeded;
            this.hypermediaLinks = hypermediaLinks;
        }
        public bool Succeeded => succeeded;

        public IList<string>? Errors => errors;

        public IList<ProjectRecord>? Data => projects;

        public IList<HypermediaLink>? Links => hypermediaLinks;
    }
}

