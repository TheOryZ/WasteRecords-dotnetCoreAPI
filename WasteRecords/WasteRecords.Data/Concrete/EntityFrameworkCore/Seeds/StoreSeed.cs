using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WasteRecords.Core.Entities;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Seeds
{
    public class StoreSeed : IEntityTypeConfiguration<Store>
    {
        public void Configure(EntityTypeBuilder<Store> builder)
        {
            builder.HasData(
                new Store { Name = "Bahçelievler Mağazası", Phone = "0212 000 11 22", Address = "Bahçelievler - İstanbul" },
                new Store { Name = "Güneşli Mağazası", Phone = "0212 000 11 22", Address = "Güneşli - İstanbul" },
                new Store { Name = "Beşiktaş Mağazası", Phone = "0212 000 11 22", Address = "Beşiktaş - İstanbul" }
                );
        }
    }
}
