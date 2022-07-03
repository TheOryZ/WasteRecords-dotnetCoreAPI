using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WasteRecords.Core.Entities;
using WasteRecords.Core.Helpers;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Seeds
{
    public class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id = 1, Name ="John Doe", Email="admin@admin.com",Password=EncryptHelper.ConvertToEncrypt("admin123") }
                );
        }
    }
}
