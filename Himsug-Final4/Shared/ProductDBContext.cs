using Himsug_Final4.Shared.DateConvert;
using Himsug_Final4.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Himsug_Final4.Shared
{
    public partial class ProductDBContext : DbContext
    {
        public ProductDBContext()
        {
        }

        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options) { 
        }

        public virtual DbSet<Product> tbl_ProductDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-5L2NHDR;Database=HimsugDB; Trusted_Connection=true; MultipleActiveResultSets=true; Encrpyt=True;");
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);

            configurationBuilder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>();
            configurationBuilder.Properties<TimeOnly>()
                .HaveConversion<TimeOnlyConverter>();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.ProductID);
            base.OnModelCreating(modelBuilder);
        }
    }
}