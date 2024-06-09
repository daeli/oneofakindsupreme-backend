using System.ComponentModel.DataAnnotations;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class DeleteProjectRequest
    {
        public const string Route = "/projects/{ProjectId:Guid}";
        public static Guid BuildRoute(Guid projectId) => Guid.Parse( Route.Replace("{ProjectId:Guid}", projectId.ToString()));

        [Required]
        public required Guid ProjectId { get; set; }
    }
}
