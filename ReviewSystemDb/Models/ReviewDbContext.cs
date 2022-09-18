using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewsCollection
{
    public class ReviewDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("data source=localhost,1433;initial catalog=ReviewDb;user id=SA;password=Carestack1234;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Review>()
                .HasIndex(review => review.ExternalReviewId)
                .IsUnique();
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}

