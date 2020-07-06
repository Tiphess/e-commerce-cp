using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class SpecificationConfiguration : IEntityTypeConfiguration<Specification>
    {
        public void Configure(EntityTypeBuilder<Specification> b)
        {
            b.HasKey(s => s.Id);

            b.Property(s => s.Title).HasMaxLength(255).IsRequired();

            b.HasMany(s => s.Categories).WithOne(sf => sf.Specification);
        }
    }
}
