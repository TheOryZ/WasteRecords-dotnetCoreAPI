using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WasteRecords.Core.Entities;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Configurations
{
    public class ReceivingCompanyConfiguration : IEntityTypeConfiguration<ReceivingCompany>
    {
        public void Configure(EntityTypeBuilder<ReceivingCompany> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CreatedDate).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
            builder.Property(x => x.IsActive).HasDefaultValueSql("((1))");
            builder.Property(x => x.IsDeleted).HasDefaultValueSql("((0))");

            builder.HasMany(x => x.Records).WithOne(x => x.ReceivingCompany).HasForeignKey(x => x.ReceivingCompanyId);
        }
    }
}
