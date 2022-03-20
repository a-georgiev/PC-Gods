using System.ComponentModel.DataAnnotations;
using static PCBuilds.Infrastructure.Data.DataConstants;

namespace PCBuilds.Infrastructure.Data.Components
{
    public class Motherboard: Component
    {
        [Required]
        [MaxLength(SocketMaxLen)]
        public string Socket { get; set; }

        [Required]
        [MaxLength(DefaultMaxLen)]
        public string Chipset { get; set; }

        [Required]
        [Range(4,512)]
        public int MaxMemmory { get; set; }

        [Required]
        [MaxLength(DefaultMaxLen)]
        public string MemmoryType { get; set; }

        [Required]
        [Range(2,20)]
        public int MemmorySlots { get; set; }

        [Required]
        [Range(800,6000)]
        public int MemmorySpeed { get; set; }
    }
}
