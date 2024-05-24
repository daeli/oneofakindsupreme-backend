using OneOfAKindSupreme.Backend.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OneOfAKindSupreme.Backend.Infrastructure.Data.EF.Entities
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public ProjectStatus Status { get; set; }
    }
}
