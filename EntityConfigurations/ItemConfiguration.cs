using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> b)
        {
            b.HasKey(i => i.Id);

            b.Property(i => i.Name).HasMaxLength(255).IsRequired();
            b.Property(i => i.Description).HasMaxLength(2000).IsRequired();
            b.Property(i => i.LimitPerCustomer).HasDefaultValue(0);
            b.Property(i => i.IsInStock).HasDefaultValue(false);
            b.Property(i => i.Price).IsRequired();
            b.Property(i => i.Category).HasMaxLength(255);

            b.HasOne(i => i.Distributor).WithMany(d => d.Items).HasForeignKey(i => i.DistributorId);
            b.HasOne(i => i.Details).WithOne(d => d.Item).HasForeignKey<Item>(i => i.DetailsId);
            b.HasOne(i => i.ReturnPolicy).WithOne(rp => rp.Item).HasForeignKey<Item>(i => i.ReturnPolicyId);
        }
    }
}
