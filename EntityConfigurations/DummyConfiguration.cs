using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class DummyConfiguration : IEntityTypeConfiguration<Dummy>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Dummy> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(d => d.Name).IsRequired().HasMaxLength(500);
        }
    }
}
