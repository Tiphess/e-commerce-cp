using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> b)
        {
            b.HasKey(o => o.Id);
            b.Property(o => o.Id).ValueGeneratedOnAdd();

            b.Property(o => o.Date).IsRequired();

            b.HasOne(o => o.User).WithMany(u => u.Orders);
        }
    }
}
