using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIGSUC.Domain.Entities.Common;
using System;

namespace SIGSUC.DAL.Entities.Common.Mapping
{
    public class UFConfiguration : IEntityTypeConfiguration<UF>
    {
        public void Configure(EntityTypeBuilder<UF> builder)
        {
            builder.HasKey(u => new { u.PaisId, u.SiglaId });

            builder.HasOne(p => p.Pais)
                .WithMany(u => u.UFs)
                .HasForeignKey(p => p.PaisId);

            builder.HasOne(f => f.Regiao)
                .WithMany(c => c.UFs)
                .HasForeignKey(h => new { h.PaisId, h.RegiaoId });


            builder.Property(p => p.PaisId)
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(p => p.SiglaId)
                .HasColumnType("varchar(2)")
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(50)")
                .IsRequired();

        }
    }
}
