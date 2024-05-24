using OneOfAKindSupreme.Backend.Core.Entities;
using OneOfAKindSupreme.Backend.Core.Interfaces.Api;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class GetByIdResponse : IResponse<ProjectRecord>
    {
        private readonly ProjectRecord projectRecord;
        private readonly List<string> errors = [];
        private readonly bool succeeded;
        private readonly IList<HypermediaLink>? hypermediaLinks;
        public GetByIdResponse(ProjectRecord projectRecord, IList<string> errors, bool succeeded, IList<HypermediaLink>? hypermediaLinks) 
        {
            this.projectRecord = projectRecord;
            if (errors is not null && errors.Count > 0) this.errors.AddRange(errors);
            this.succeeded = succeeded;
            this.hypermediaLinks = hypermediaLinks;
        }
        public bool Succeeded => succeeded;

        public IList<string>? Errors => errors;

        public ProjectRecord? Data => projectRecord;

        public IList<HypermediaLink>? Links => hypermediaLinks;
    }
}
