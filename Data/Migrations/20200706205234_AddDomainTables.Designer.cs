﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using e_commerce_cp.Data;

namespace e_commerce_cp.Migrations
{
    [DbContext(typeof(ECommerceCPContext))]
    [Migration("20200706205234_AddDomainTables")]
    partial class AddDomainTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("e_commerce_cp.Models.Cart", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Detail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Distributor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("WebsiteProductPageUrl")
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.Property<string>("WebsiteUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.HasKey("Id");

                    b.ToTable("Distributors");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Item", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<int>("DetailsId")
                        .HasColumnType("int");

                    b.Property<int>("DistributorId")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image1")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image2")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("Image3")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsInStock")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int>("LimitPerCustomer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ReturnPolicyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DetailsId")
                        .IsUnique();

                    b.HasIndex("DistributorId");

                    b.HasIndex("ReturnPolicyId")
                        .IsUnique();

                    b.ToTable("Items");
                });

            modelBuilder.Entity("e_commerce_cp.Models.ItemCart", b =>
                {
                    b.Property<string>("CartId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CartId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("ItemCarts");
                });

            modelBuilder.Entity("e_commerce_cp.Models.ItemOrder", b =>
                {
                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("ItemId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("ItemOrders");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpectedArrival")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("e_commerce_cp.Models.ReturnPolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ReturnForRefundWithinDays")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("ReturnForReplacementWithinDays")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("ReturnPolicies");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(3000)")
                        .HasMaxLength(3000);

                    b.Property<string>("ItemId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Specification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DetailId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("DetailId");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("e_commerce_cp.Models.SpecificationField", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<int?>("SpecificationId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("SpecificationId");

                    b.ToTable("SpecificationFields");
                });

            modelBuilder.Entity("e_commerce_cp.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("e_commerce_cp.Models.UserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Cart", b =>
                {
                    b.HasOne("e_commerce_cp.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Item", b =>
                {
                    b.HasOne("e_commerce_cp.Models.Detail", "Details")
                        .WithOne("Item")
                        .HasForeignKey("e_commerce_cp.Models.Item", "DetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_commerce_cp.Models.Distributor", "Distributor")
                        .WithMany("Items")
                        .HasForeignKey("DistributorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_commerce_cp.Models.ReturnPolicy", "ReturnPolicy")
                        .WithOne("Item")
                        .HasForeignKey("e_commerce_cp.Models.Item", "ReturnPolicyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e_commerce_cp.Models.ItemCart", b =>
                {
                    b.HasOne("e_commerce_cp.Models.Cart", "Cart")
                        .WithMany("ItemCarts")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_commerce_cp.Models.Item", "Item")
                        .WithMany("ItemCarts")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e_commerce_cp.Models.ItemOrder", b =>
                {
                    b.HasOne("e_commerce_cp.Models.Item", "Item")
                        .WithMany("ItemOrders")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_commerce_cp.Models.Order", "Order")
                        .WithMany("ItemOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("e_commerce_cp.Models.Order", b =>
                {
                    b.HasOne("e_commerce_cp.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Review", b =>
                {
                    b.HasOne("e_commerce_cp.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("e_commerce_cp.Models.Specification", b =>
                {
                    b.HasOne("e_commerce_cp.Models.Detail", "Detail")
                        .WithMany("Specifications")
                        .HasForeignKey("DetailId");
                });

            modelBuilder.Entity("e_commerce_cp.Models.SpecificationField", b =>
                {
                    b.HasOne("e_commerce_cp.Models.Specification", "Specification")
                        .WithMany("Categories")
                        .HasForeignKey("SpecificationId");
                });

            modelBuilder.Entity("e_commerce_cp.Models.UserRole", b =>
                {
                    b.HasOne("e_commerce_cp.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("e_commerce_cp.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
