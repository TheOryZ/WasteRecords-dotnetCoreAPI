namespace WasteRecords.Core.Dtos.Record
{
    public class RecordAddDto
    {
        public int StoreId { get; set; }
        public int WasteTypeId { get; set; }
        public int KindOfWasteId { get; set; }
        public int UnitId { get; set; }
        public int ReceivingCompanyId { get; set; }
        public string Month { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? OperationDate { get; set; }
        public string Content { get; set; }
        public string ContentLanguage { get; set; }
    }
}
