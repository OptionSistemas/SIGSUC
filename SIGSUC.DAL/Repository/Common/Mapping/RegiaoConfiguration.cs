using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIGSUC.Domain.Entities.Common;
using System;

namespace SIGSUC.DAL.Entities.Common.Mapping
{
    public class RegiaoConfiguration : IEntityTypeConfiguration<Regiao>
    {
        public void Configure(EntityTypeBuilder<Regiao> builder)
        {
            builder.HasKey(u => new { u.PaisId, u.RegiaoId });

            builder.HasOne(p => p.Pais).WithMany(u => u.Regioes)
                .HasForeignKey(p => p.PaisId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Property(p => p.PaisId)
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(p => p.RegiaoId)
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(50)")
                .IsRequired();

        }
    }
}
