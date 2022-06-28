using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WasteRecords.Core.Entities;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Seeds
{
    public class ReceivingCompanySeed : IEntityTypeConfiguration<ReceivingCompany>
    {
        public void Configure(EntityTypeBuilder<ReceivingCompany> builder)
        {
            builder.HasData(
                new ReceivingCompany { Description = "Çöp - Belediye"},
                new ReceivingCompany { Description = "Hayvan Barınağı" },
                new ReceivingCompany { Description = "Geri Dönüşüm" }
                );
        }
    }
}
