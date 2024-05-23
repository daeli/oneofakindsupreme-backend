using System.ComponentModel.DataAnnotations;

namespace OneOfAKindSupreme.Backend.Web.Api.Projects
{
    public class CreateProjectRequest
    {
        public const string Route = "/projects";

        [Required]
        public required string Name { get; set; }
        public string? Status { get; set; }
    }
}
