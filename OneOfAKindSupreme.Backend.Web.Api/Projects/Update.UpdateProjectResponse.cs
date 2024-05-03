namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class UpdateProjectResponse(ProjectRecord project)
    {
        public ProjectRecord Project { get; set; } = project;
    }
}
