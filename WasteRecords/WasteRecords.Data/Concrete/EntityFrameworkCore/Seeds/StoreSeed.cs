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
                new Store { Id = 1, Name = "Bahçelievler Mağazası", Phone = "0212 000 11 22", Address = "Bahçelievler - İstanbul" },
                new Store { Id = 2, Name = "Güneşli Mağazası", Phone = "0212 000 11 22", Address = "Güneşli - İstanbul" },
                new Store { Id = 3, Name = "Beşiktaş Mağazası", Phone = "0212 000 11 22", Address = "Beşiktaş - İstanbul" }
                );
        }
    }
}
