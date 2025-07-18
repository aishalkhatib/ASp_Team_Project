using Microsoft.EntityFrameworkCore;
using WaterDistribution_MS.Models;
using Microsoft.Data.SqlClient;

namespace WaterDistribution_MS.Data
{
    public partial class AppDbContext : DbContext
    {

            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }

            public virtual DbSet<Customer> Customers { get; set; }
            public virtual DbSet<Rogion> Rogions { get; set; }
            public virtual DbSet<Tank> Tanks { get; set; }
            public virtual DbSet<Order> Orders { get; set; }
            public virtual DbSet<Driver> Drivers { get; set; }
            public virtual DbSet<TankArea> TankAreas { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<TankArea>()
                    .HasKey(ta => new { ta.TankId, ta.RogionId });  // المفتاح يتكون من TankId و AreaId معًا

                // إعداد العلاقة مع جدول Tanks
                modelBuilder.Entity<TankArea>()
                    .HasOne(ta => ta.Tank)               // كل سجل في TankArea يرتبط بـ Tank واحد
                    .WithMany(t => t.tankAreas)          // وكل خزان يمكن أن يكون مرتبطًا بعدة سجلات في TankArea
                    .HasForeignKey(ta => ta.TankId);     // المفتاح الأجنبي هو TankId

                // إعداد العلاقة مع جدول Areas
                modelBuilder.Entity<TankArea>()
                    .HasOne(ta => ta.Rogion)               // كل سجل في TankArea يرتبط بمنطقة واحدة
                    .WithMany(a => a.TankAreas)          // وكل منطقة يمكن أن تكون مرتبطة بعدة سجلات في TankArea
                    .HasForeignKey(ta => ta.RogionId);
            }
        }
    }
