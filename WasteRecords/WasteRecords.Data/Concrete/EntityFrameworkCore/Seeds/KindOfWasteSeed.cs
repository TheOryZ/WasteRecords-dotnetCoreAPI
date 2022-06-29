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
                new KindOfWaste { Id = 1, Description = "Konserve"},
                new KindOfWaste { Id = 2, Description = "Unlu Mamüller" },
                new KindOfWaste { Id = 3, Description = "Şaraplar" },
                new KindOfWaste { Id = 4, Description = "Et" }
                );
        }
    }
}
