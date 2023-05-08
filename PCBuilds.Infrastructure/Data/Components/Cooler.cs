using System.ComponentModel.DataAnnotations;
using static PCBuilds.Infrastructure.Data.DataConstants;

namespace PCBuilds.Infrastructure.Data.Components
{
    public class Cooler: Component
    {
        [Required]
        [MaxLength(ModelMaxLen)]
        public string Model { get; set; }

        [Required]
        public int MinRpm{ get; set; }

        [Required]
        public int MaxRpm { get; set; }

        [Required]
        public int Noise { get; set; }

        [Required]
        [MaxLength(SocketMaxLen)]
        public string Socket { get; set; }

    }
}
