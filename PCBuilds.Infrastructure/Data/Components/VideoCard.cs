using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static PCBuilds.Infrastructure.Data.DataConstants;

namespace PCBuilds.Infrastructure.Data.Components
{
    public class VideoCard: Component
    {
        [Required]
        [MaxLength(DefaultMaxLen)]
        public string Chipset { get; set; }

        [Required]
        [Range(1,48)]
        public int Memmory { get; set; }

        [Required]
        [MaxLength(DefaultMaxLen)]
        public string MemmoryType { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal CoreClock { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal BoostClock { get; set; }

        [Required]
        public int Tdp { get; set; }
    }
}
