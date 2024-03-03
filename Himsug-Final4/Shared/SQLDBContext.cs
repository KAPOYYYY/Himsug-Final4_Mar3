using Himsug_Final4.Shared.DateConvert;
using Himsug_Final4.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Himsug_Final4.Shared
{
    public partial class SQLDBContext : DbContext
    {
        public SQLDBContext() { }

        public SQLDBContext(DbContextOptions<SQLDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        
        {
            if (!optionsBuilder.IsConfigured)
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
            modelBuilder.Entity<Accounts>().HasKey(u => u.AccountsID);
            base.OnModelCreating(modelBuilder);
        }
    }
}
