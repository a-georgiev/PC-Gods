using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static PCBuilds.Infrastructure.Data.DataConstants;


namespace PCBuilds.Infrastructure.Data.Components
{
    public class Memmory: Component
    {
        [Required]
        [MaxLength(DefaultMaxLen)]
        public string Type { get; set; }

        [Required]
        [Range(1,10)]
        public int Modules { get; set; }

        [Required]
        [Range(4,128)]
        public int Capacity { get; set; }

        [Required]
        [Range(1,30)]
        public int Cas { get; set; }

        [Required]
        [Precision(18,2)]
        public decimal Voltage { get; set; }
    }
}
