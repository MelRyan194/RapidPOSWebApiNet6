using Microsoft.EntityFrameworkCore;
using RapidPOSWebApiNet6.Data.Models;

namespace RapidPOSWebApiNet6.Data
{
    public class ApiDbContext: DbContext
    {
        public ApiDbContext(DbContextOptions options):base(options)
        {
                
        }

        public DbSet<CustomerEntity> AR_CUST { get; set; }
        public DbSet<PaymentEntity> PS_DOC_PMT { get; set; }
        public DbSet<SaleStoreEntity> PS_STR { get; set; }
        public DbSet<SaleStationEntity> PS_STA { get; set; }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);  //require for Identity Framework

            modelbuilder.Entity<PaymentEntity>().HasKey("DOC_ID", "PMT_SEQ_NO");
            modelbuilder.Entity<SaleStationEntity>().HasKey("STR_ID", "STA_ID");
        }
    }
}
