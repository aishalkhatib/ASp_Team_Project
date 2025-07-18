﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WaterDistribution_MS.Data;

#nullable disable

namespace WaterDistribution_MS.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WaterDistribution_MS.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoginId")
                        .HasColumnType("int");

                    b.Property<int>("RogionId")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RogionId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("work")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DriverId")
                        .HasColumnType("int");

                    b.Property<int>("TankId")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("stat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("time")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DriverId");

                    b.HasIndex("TankId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.Rogion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rogions");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.Tank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("capacity")
                        .HasColumnType("float");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Tanks");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.TankArea", b =>
                {
                    b.Property<int>("TankId")
                        .HasColumnType("int");

                    b.Property<int>("RogionId")
                        .HasColumnType("int");

                    b.HasKey("TankId", "RogionId");

                    b.HasIndex("RogionId");

                    b.ToTable("TankAreas");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.Customer", b =>
                {
                    b.HasOne("WaterDistribution_MS.Models.Rogion", "Rogion")
                        .WithMany("Customers")
                        .HasForeignKey("RogionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rogion");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.Order", b =>
                {
                    b.HasOne("WaterDistribution_MS.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WaterDistribution_MS.Models.Driver", "Driver")
                        .WithMany("orders")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WaterDistribution_MS.Models.Tank", "Tank")
                        .WithMany("orders")
                        .HasForeignKey("TankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Driver");

                    b.Navigation("Tank");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.TankArea", b =>
                {
                    b.HasOne("WaterDistribution_MS.Models.Rogion", "Rogion")
                        .WithMany("TankAreas")
                        .HasForeignKey("RogionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WaterDistribution_MS.Models.Tank", "Tank")
                        .WithMany("tankAreas")
                        .HasForeignKey("TankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rogion");

                    b.Navigation("Tank");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.Driver", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.Rogion", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("TankAreas");
                });

            modelBuilder.Entity("WaterDistribution_MS.Models.Tank", b =>
                {
                    b.Navigation("orders");

                    b.Navigation("tankAreas");
                });
#pragma warning restore 612, 618
        }
    }
}
