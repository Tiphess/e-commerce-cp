using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class ItemOrderConfiguration : IEntityTypeConfiguration<ItemOrder>
    {
        public void Configure(EntityTypeBuilder<ItemOrder> b)
        {
            b.HasKey(io => new { io.ItemId, io.OrderId });

            b.HasOne(io => io.Item).WithMany(i => i.ItemOrders).HasForeignKey(io => io.ItemId);
            b.HasOne(io => io.Order).WithMany(i => i.ItemOrders).HasForeignKey(io => io.OrderId);
        }
    }
}
