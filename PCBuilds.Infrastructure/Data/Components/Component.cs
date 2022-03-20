using System.ComponentModel.DataAnnotations;
using static PCBuilds.Infrastructure.Data.DataConstants;

namespace PCBuilds.Infrastructure.Data.Components
{
    public abstract class Component
    {
        [Key]
        public Guid Id { get; init; } = new Guid();
        
        [Required]
        [MaxLength(ManufacturerMaxLen)]
        public string Manufacturer { get; init; }

        [Required]
        [MaxLength(ManufacturerMaxLen)]
        public string PartNumber { get; init; }
    }
}
