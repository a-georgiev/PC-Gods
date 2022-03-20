using PCBuilds.Infrastructure.Data.Components;
using System.ComponentModel.DataAnnotations;
using static PCBuilds.Infrastructure.Data.DataConstants;

namespace PCBuilds.Infrastructure.Data
{
    public class Build
    {
        public Guid Id { get; set; } = new Guid();

        [Required]
        [MaxLength(DecsriptionMaxLen)]
        public string Desciption { get; set; }

        [Required]
        public Guid CpuId { get; set; }

        public Cpu Cpu{ get; set; }

        [Required]
        public Guid CoolerId { get; set; }

        public Cooler Cooler { get; set; }

        [Required]
        public Guid MotherboardId { get; set; }

        public Motherboard Motherboard { get; set; }

        public IEnumerable<Memmory> Memmories { get; set; } = new List<Memmory>();

        public IEnumerable<Storage> Storages{ get; set; } = new List<Storage>();
        
        [Required]
        public Guid VideoCardId { get; set; }

        public VideoCard VideoCard { get; set; }

        [Required]
        public Guid PowerSupplyId { get; set; }

        public PowerSupply PowerSupply { get; set; }

    }
}
