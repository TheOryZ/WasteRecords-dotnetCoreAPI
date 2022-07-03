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
        public string Month { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? OperationDate { get; set; }
        public string Content { get; set; }
        public string ContentLanguage { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Store Store { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual WasteType WasteType { get; set; }
        public virtual KindOfWaste KindOfWaste { get; set; }
        public virtual ReceivingCompany ReceivingCompany { get; set; }
    }
}
