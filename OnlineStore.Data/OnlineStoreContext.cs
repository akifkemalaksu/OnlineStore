using OnlineStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Data
{
    public class OnlineStoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public OnlineStoreContext()
            : base("OnlineStoreDbContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                .HasRequired<Category>(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.AllowedCategories)
                .WithMany(c => c.AssignedUsers)
                .Map(mapping =>
                {
                    mapping.MapLeftKey("UserId");
                    mapping.MapRightKey("CategoryId");
                    mapping.ToTable("UserCategory");
                });
        }
    }
}
