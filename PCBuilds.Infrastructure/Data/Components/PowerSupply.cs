using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace PCBuilds.Infrastructure.Data.Components
{
    public class PowerSupply: Component
    {
        [Required]
        [Precision(18,2)]
        public decimal EfficientyPercent { get; set; }

        [Required]
        [Precision(18, 2)]
        public decimal Watage { get; set; }

        public bool IsModular { get; set; }

    }
}
