using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PCBuilds.Infrastructure.Data;
using PCBuilds.Infrastructure.Data.Components;

namespace PCBuilds.Data
{
    public class PCBuildDbContext : IdentityDbContext
    {
        public PCBuildDbContext()
        {

        }
        public DbSet<Build> Builds{ get; set; }
        public DbSet<Cpu> Cpus{ get; set; }
        public DbSet<Cooler> Coolers{ get; set; }
        public DbSet<Memmory> Memmories{ get; set; }
        public DbSet<Motherboard> Motherboards{ get; set; }
        public DbSet<PowerSupply> PowerSupplies{ get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<VideoCard> VideoCards { get; set; }

        public PCBuildDbContext(DbContextOptions<PCBuildDbContext> options)
            : base(options)
        {

        }

    }
}