using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityCoffeeShop.Table;
using Microsoft.EntityFrameworkCore;

namespace EntityCoffeeShop.Model
{
    public class CoffeeShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users {get; set;}
        public DbSet<UserProfile> UserProfiles {get; set;}


        private string conStriing = "Data Source=V-SAL;Initial Catalog=coffeeshop_db;Integrated Security=True;Trust Server Certificate=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(conStriing);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Seed initial categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Coffee" },
                new Category { CategoryId = 2, Name = "Tea" },
                new Category { CategoryId = 3, Name = "Snack" }
            );
           
            modelBuilder.Entity<User>()
             .HasIndex(u => u.Username)
             .IsUnique();

            modelBuilder.Entity<User>()
                .Property(u => u.role)
                .HasConversion<string>();

            modelBuilder.Entity<User>()
                .HasOne(u => u.Profile)
                .WithOne(p => p.User)
                .HasForeignKey<UserProfile>(p => p.UserId);

        }
    }

}
