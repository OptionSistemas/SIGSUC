using Microsoft.EntityFrameworkCore;
using SIGSUC.Domain.Entities.Common;
using SIGSUC.DAL.Entities.Common.Mapping;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SIGSUC.DAL.Context
{
    public class SIGSUCContext : IdentityDbContext
    {
        public DbSet<Continente> Continentes { get; set; }
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Regiao> Regioes { get; set; }
        public DbSet<UF> UFs { get; set; }

        public SIGSUCContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContinenteConfiguration());
            modelBuilder.ApplyConfiguration(new PaisConfiguration());
            modelBuilder.ApplyConfiguration(new UFConfiguration());
            modelBuilder.ApplyConfiguration(new RegiaoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
