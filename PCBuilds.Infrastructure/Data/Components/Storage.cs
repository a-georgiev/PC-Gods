using System.ComponentModel.DataAnnotations;
using static PCBuilds.Infrastructure.Data.DataConstants;

namespace PCBuilds.Infrastructure.Data.Components
{
    public  class Storage: Component
    {
        [Required]
        [MaxLength]
        public string Type { get; set; }

        [Required]
        [MaxLength(DefaultMaxLen)]
        public int Capacity { get; set; }

        [Required]
        [MaxLength(DefaultMaxLen)]
        public string Interface { get; set; }

    }
}
