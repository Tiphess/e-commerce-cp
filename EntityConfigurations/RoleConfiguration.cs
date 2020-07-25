using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.EntityConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> b)
        {
            b.HasKey(r => r.Id);
            b.Property(r => r.Id).ValueGeneratedOnAdd();

            b.Property(r => r.Name).HasMaxLength(255).IsRequired();
        }
    }
}
