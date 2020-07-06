using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class ItemCartConfiguration : IEntityTypeConfiguration<ItemCart>
    {
        public void Configure(EntityTypeBuilder<ItemCart> b)
        {
            b.HasKey(ic => new { ic.CartId, ic.ItemId });

            b.HasOne(ic => ic.Cart).WithMany(c => c.ItemCarts).HasForeignKey(ic => ic.CartId);
            b.HasOne(ic => ic.Item).WithMany(i => i.ItemCarts).HasForeignKey(ic => ic.ItemId);
        }
    }
}
