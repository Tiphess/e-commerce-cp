using e_commerce_cp.EntityConfigurations;
using e_commerce_cp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_cp.Data
{
    public class ECommerceCPContext : DbContext
    {
        public ECommerceCPContext(DbContextOptions<ECommerceCPContext> options) : base(options)
        {
        }

        public DbSet<Dummy> Dummies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DummyConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
