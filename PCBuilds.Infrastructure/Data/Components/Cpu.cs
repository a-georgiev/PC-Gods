using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static PCBuilds.Infrastructure.Data.DataConstants;

namespace PCBuilds.Infrastructure.Data.Components
{
    public class Cpu: Component
    {
        [Required]
        public int CoresCount { get; set; }
        
        [Required]
        [Precision(18,2)]
        public decimal CoreClock { get; set; }

        [Required]
        [Precision(18,2)]
        public decimal BoostClock { get; set; }

        [Required]
        public int Tdp { get; set; }

        [Required]
        [MaxLength(DefaultMaxLen)]
        public string Series { get; set; }

        [Required]
        [MaxLength(DefaultMaxLen)]
        public string Microarchitecture { get; set; }
        
        public bool HasIntegratedGraphic { get; set; }

        [Required]
        public int MaxMemmory { get; set; }
        
        public bool HasCooler { get; set; }
       
        [Required]
        [MaxLength(SocketMaxLen)]
        public string Socket { get; set; }

    }
}
