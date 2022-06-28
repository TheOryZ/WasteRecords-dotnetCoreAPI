namespace WasteRecords.Core.Entities
{
    public class Record : BaseEntity
    {
        public int StoreId { get; set; }
        public int WasteTypeId { get; set; }
        public int KindOfWasteId { get; set; }
        public int UnitId { get; set; }
        public int ReceivingCompanyId { get; set; }
        public decimal Quantity { get; set; }
    }
}
