using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> b)
        {
            b.HasKey(d => d.Id);

            b.HasOne(d => d.Item).WithOne(i => i.Details);
            b.HasMany(d => d.Specifications).WithOne(s => s.Detail);
        }
    }
}
