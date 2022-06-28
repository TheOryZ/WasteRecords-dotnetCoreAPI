using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WasteRecords.Core.Entities;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Seeds
{
    public class KindOfWasteSeed : IEntityTypeConfiguration<KindOfWaste>
    {
        public void Configure(EntityTypeBuilder<KindOfWaste> builder)
        {
            builder.HasData(
                new KindOfWaste { Description = "Konserve"},
                new KindOfWaste { Description = "Unlu Mamüller" },
                new KindOfWaste { Description = "Şaraplar" },
                new KindOfWaste { Description = "Et" }
                );
        }
    }
}
