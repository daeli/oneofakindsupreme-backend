using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.Core.Extensions
{
    public static class ProjectExtension
    {
        public static ProjectStatus ToProjectStatus(this string? status) => status?.ToLower() switch 
        { 
            "pending" => ProjectStatus.Pending,
            "inprogress" => ProjectStatus.InProgress,
            "done" => ProjectStatus.Done,
            _ => ProjectStatus.Pending,
        };
    }
}
