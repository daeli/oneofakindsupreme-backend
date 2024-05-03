using OneOfAKindSupreme.Backend.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class UpdateProjectRequest
    {
        public const string Route = "/Projects/{ProjectId:int}";
        public static string BuildRoute(int projectId) => Route.Replace("{ProjectId:int}", projectId.ToString());

        public int ProjectId { get; set; }

        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Status { get; set; }
    }
}
