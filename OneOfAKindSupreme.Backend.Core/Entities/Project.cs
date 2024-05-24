
namespace OneOfAKindSupreme.Backend.Core.Entities
{
    public class Project
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public ProjectStatus Status { get; set; }
    }
}
