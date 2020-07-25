using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> b)
        {
            b.HasKey(c => c.Id);
            b.Property(c => c.Id).ValueGeneratedOnAdd();
            //b.HasOne(c => c.User).WithOne(u => u.ShoppingCart);
        }
    }
}
