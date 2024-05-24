using OneOfAKindSupreme.Backend.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class UpdateProjectRequest
    {
        public const string Route = "/projects/{ProjectId:guid}";
        public static string BuildRoute(int projectId) => Route.Replace("{ProjectId:guid}", projectId.ToString());

        public Guid ProjectId { get; set; }

        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Status { get; set; }
    }
}
