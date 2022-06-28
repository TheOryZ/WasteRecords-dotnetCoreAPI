using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WasteRecords.Core.Entities;

namespace WasteRecords.Data.Concrete.EntityFrameworkCore.Configurations
{
    public class RecordConfiguration : IEntityTypeConfiguration<Record>
    {
        public void Configure(EntityTypeBuilder<Record> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Content).HasColumnType("ntext").IsUnicode(false);
            builder.Property(x => x.StoreId).IsRequired();
            builder.Property(x => x.UnitId).IsRequired();
            builder.Property(x => x.WasteTypeId).IsRequired();
            builder.Property(x => x.KindOfWasteId).IsRequired();
            builder.Property(x => x.ReceivingCompanyId).IsRequired();
            builder.Property(x => x.CreatedDate).HasColumnType("datetime").HasDefaultValueSql("(getdate())");
            builder.Property(x => x.IsActive).HasDefaultValueSql("((1))");
            builder.Property(x => x.IsDeleted).HasDefaultValueSql("((0))");
        }
    }
}
