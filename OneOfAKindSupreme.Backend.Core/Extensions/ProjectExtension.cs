using OneOfAKindSupreme.Backend.Core.Entities;

namespace OneOfAKindSupreme.Backend.Core.Extensions
{
    public static class ProjectExtension
    {
        public static ProjectStatus ToProjectStatus(this string? status)
        {
            if (status == null) return ProjectStatus.Pending;

            if (status.ToLower() == "inprogress") return ProjectStatus.InProgress;

            return ProjectStatus.Done;
        }
    }
}
