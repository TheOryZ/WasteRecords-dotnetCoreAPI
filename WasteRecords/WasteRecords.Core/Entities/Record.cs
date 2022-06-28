using WasteRecords.Core.Interfaces;

namespace WasteRecords.Core.Entities
{
    public class Record : IEntity
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public int WasteTypeId { get; set; }
        public int KindOfWasteId { get; set; }
        public int UnitId { get; set; }
        public int ReceivingCompanyId { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
