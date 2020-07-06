using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class DistributorConfiguration : IEntityTypeConfiguration<Distributor>
    {
        public void Configure(EntityTypeBuilder<Distributor> b)
        {
            b.HasKey(d => d.Id);

            b.Property(d => d.Name).HasMaxLength(255).IsRequired();
            b.Property(d => d.Phone).HasMaxLength(20).IsRequired();
            b.Property(d => d.WebsiteUrl).HasMaxLength(2000).IsRequired();
            b.Property(d => d.WebsiteProductPageUrl).HasMaxLength(4000);

            b.HasMany(d => d.Items).WithOne(i => i.Distributor);
        }
    }
}
