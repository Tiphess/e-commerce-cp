//using e_commerce_cp.EntityConfigurations;
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

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemCart> ItemCarts { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Distributor> Distributors { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<ReturnPolicy> ReturnPolicies { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<SpecificationField> SpecificationFields { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new CartConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new ItemConfiguration());
            builder.ApplyConfiguration(new ItemCartConfiguration());
            builder.ApplyConfiguration(new ItemOrderConfiguration());
            builder.ApplyConfiguration(new ReviewConfiguration());
            builder.ApplyConfiguration(new DistributorConfiguration());
            builder.ApplyConfiguration(new DetailConfiguration());
            builder.ApplyConfiguration(new ReturnPolicyConfiguration());
            builder.ApplyConfiguration(new SpecificationConfiguration());
            builder.ApplyConfiguration(new SpecificationFieldConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
