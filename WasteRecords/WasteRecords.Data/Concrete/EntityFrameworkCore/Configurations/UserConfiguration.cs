using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WasteRecords.Core.Entities;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.HasIndex(x => x.Email).IsUnique(true);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CreatedDate).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
            builder.Property(x => x.IsActive).HasDefaultValueSql("((1))");
            builder.Property(x => x.IsDeleted).HasDefaultValueSql("((0))");
        }
    }
}
