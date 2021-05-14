using HomeworkEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeworkEFCore
{
    public class OrdersSummaryDbContext : DbContext
    {

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public OrdersSummaryDbContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(order =>
            {
                order.HasKey(o => o.Id);

                order.Property(o => o.Name)
                    .HasMaxLength(50)
                    .IsRequired(true) //true default value
                    .IsUnicode(true);

                order.HasOne(o => o.Customer)
                    .WithMany(c => c.Orders)
                    .HasForeignKey(o => o.CustomerId)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Customer>(customer =>
            {
                customer.HasKey(c => c.Id);

                customer.Property(c => c.Name)
                    .HasMaxLength(50)
                    .IsRequired(true) //true default value
                    .IsUnicode(true);
            });
        }
    }
}
