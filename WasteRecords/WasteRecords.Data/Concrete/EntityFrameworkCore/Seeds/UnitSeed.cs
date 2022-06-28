using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WasteRecords.Core.Entities;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Seeds
{
    public class UnitSeed : IEntityTypeConfiguration<Unit>
    {
        public void Configure(EntityTypeBuilder<Unit> builder)
        {
            builder.HasData(
                new Unit { Description = "KG"},
                new Unit { Description = "Adet" }
                );
        }
    }
}
