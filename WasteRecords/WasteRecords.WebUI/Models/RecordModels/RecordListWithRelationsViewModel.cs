using WasteRecords.WebUI.Models.KinfOfWaste;
using WasteRecords.WebUI.Models.ReceivingCompany;
using WasteRecords.WebUI.Models.Store;
using WasteRecords.WebUI.Models.Unit;
using WasteRecords.WebUI.Models.WasteType;

namespace WasteRecords.WebUI.Models.RecordModels
{
    public class RecordListWithRelationsViewModel : RecordListViewModel
    {
        public StoreListViewModel Store { get; set; }
        public UnitListViewModel Unit { get; set; }
        public WasteTypeListViewModel WasteType { get; set; }
        public KindOfWasteListViewModel KindOfWaste { get; set; }
        public ReceivingCompanyListViewModel ReceivingCompany { get; set; }
    }
}
