using Draft.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Persistence.Configuration
{
    public class TypeMaterialConfiguration : IEntityTypeConfiguration<TypeMaterial>
    {
        public void Configure(EntityTypeBuilder<TypeMaterial> builder)
        {
            builder.HasKey(e => e.Id);
            builder.HasIndex(e => e.Id).IsUnique();
            builder.Property(e => e.Name).HasMaxLength(100);
        }
    }
}
