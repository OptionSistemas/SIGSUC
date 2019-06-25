using Microsoft.EntityFrameworkCore;
using SIGSUC.Domain.Entities.Common;
using SIGSUC.DAL.Entities.Common.Mapping;

namespace SIGSUC.DAL.Context
{
    public class SIGSUCContext : DbContext
    {
        public DbSet<Pais> Paises { get; set; }
        public DbSet<UF> UFs { get; set; }

        public SIGSUCContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PaisConfiguration());
            modelBuilder.ApplyConfiguration(new UFConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
