using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WasteRecords.Core.Entities;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Seeds
{
    public class WasteTypeSeed : IEntityTypeConfiguration<WasteType>
    {
        public void Configure(EntityTypeBuilder<WasteType> builder)
        {
            builder.HasData(
                new WasteType { Id = 1, Description = "Çöp"},
                new WasteType { Id = 2, Description = "Barınak" }
                );
        }
    }
}
