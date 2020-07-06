using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class ReturnPolicyConfiguration : IEntityTypeConfiguration<ReturnPolicy>
    {
        public void Configure(EntityTypeBuilder<ReturnPolicy> b)
        {
            b.HasKey(rp => rp.Id);

            b.Property(rp => rp.ReturnForRefundWithinDays).HasDefaultValue(0);
            b.Property(rp => rp.ReturnForReplacementWithinDays).HasDefaultValue(0);

            b.HasOne(rp => rp.Item).WithOne(i => i.ReturnPolicy);
        }
    }
}
