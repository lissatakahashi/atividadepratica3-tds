using Microsoft.EntityFrameworkCore;
using tpte03.RazorPages.Models;

namespace tpte03.RazorPages.Data {
    public class AppDbContext : DbContext
    {
        public DbSet<FeedbackModel>? Feedbacks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=tds.db;Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedbackModel>().ToTable("Feedbacks");
        }
    }
}