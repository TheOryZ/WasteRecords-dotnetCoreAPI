using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WasteRecords.Core.Entities;
using WasteRecords.Data.Concrete.EntityFrameworkCore.Configurations;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Context
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("EntityFrameWorkConnectionString"));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configurations
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new StoreConfiguration());
            modelBuilder.ApplyConfiguration(new UnitConfiguration());
            modelBuilder.ApplyConfiguration(new WasteTypeConfiguration());
            modelBuilder.ApplyConfiguration(new KindOfWasteConfiguration());
            modelBuilder.ApplyConfiguration(new ReceivingCompanyConfiguration());
            modelBuilder.ApplyConfiguration(new RecordConfiguration());
            #endregion
            #region Seeds

            #endregion
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<WasteType> WasteTypes { get; set; }
        public DbSet<KindOfWaste> KindOfWastes { get; set; }
        public DbSet<ReceivingCompany> ReceivingCompanies { get; set; }
        public DbSet<Record> Records { get; set; }
    }
}
