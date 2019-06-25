using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIGSUC.Domain.Entities.Common;
using System;

namespace SIGSUC.DAL.Entities.Common.Mapping
{
    public class ContinenteConfiguration : IEntityTypeConfiguration<Continente>
    {
        public void Configure(EntityTypeBuilder<Continente> builder)
        {
            builder.HasKey(c => c.ContinenteId);

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(40)")
                .IsRequired();

        }
    }
}
