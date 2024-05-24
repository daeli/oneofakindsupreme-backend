namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class GetProjectByIdRequest
    {
        public const string Route = "/projects/{ProjectId:Guid}";
        public static string BuildRoute(Guid projectId) => Route.Replace("{ProjectId:Guid}", projectId.ToString());

        public Guid ProjectId { get; set; }
    }
}
