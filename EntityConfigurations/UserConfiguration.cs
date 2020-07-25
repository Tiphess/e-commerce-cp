using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> b)
        {
            b.HasKey(u => u.Id);
            b.Property(u => u.Id).ValueGeneratedOnAdd();

            b.Property(u => u.FirstName).HasMaxLength(255).IsRequired();
            b.Property(u => u.LastName).HasMaxLength(255).IsRequired();
            b.Property(u => u.Email).HasMaxLength(255).IsRequired();
            b.Property(u => u.Phone).HasMaxLength(20).IsRequired();
            b.Property(u => u.Password).HasMaxLength(255).IsRequired();

            //b.HasOne(u => u.ShoppingCart).WithOne(c => c.User).HasForeignKey<User>(u => u.ShoppingCartId);
            b.HasMany(u => u.Orders).WithOne(o => o.User);

        }
    }
}
