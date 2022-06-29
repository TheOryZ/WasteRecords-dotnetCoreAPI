using WasteRecords.Core.Dtos.KindOfWaste;
using WasteRecords.Core.Dtos.ReceivingCompany;
using WasteRecords.Core.Dtos.Store;
using WasteRecords.Core.Dtos.Unit;
using WasteRecords.Core.Dtos.WasteType;

namespace WasteRecords.Core.Dtos.Record
{
    public class RecordListWithRelationsDto : RecordListDto
    {
        public StoreListDto Store { get; set; }
        public UnitListDto Unit { get; set; }
        public WasteTypeListDto WasteType { get; set; }
        public KindOfWasteListDto KindOfWaste { get; set; }
        public ReceivingCompanyListDto ReceivingCompany { get; set; }
    }
}
