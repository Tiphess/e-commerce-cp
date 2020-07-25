using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class SpecificationFieldConfiguration : IEntityTypeConfiguration<SpecificationField>
    {
        public void Configure(EntityTypeBuilder<SpecificationField> b)
        {
            b.HasKey(sf => sf.Id);
            b.Property(sf => sf.Id).ValueGeneratedOnAdd();

            b.Property(sf => sf.Title).HasMaxLength(255).IsRequired();
            b.Property(sf => sf.Content).HasMaxLength(2000).IsRequired();
        }
    }
}
