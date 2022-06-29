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
                new ReceivingCompany { Id = 1, Description = "Çöp - Belediye"},
                new ReceivingCompany { Id = 2, Description = "Hayvan Barınağı" },
                new ReceivingCompany { Id = 3, Description = "Geri Dönüşüm" }
                );
        }
    }
}
