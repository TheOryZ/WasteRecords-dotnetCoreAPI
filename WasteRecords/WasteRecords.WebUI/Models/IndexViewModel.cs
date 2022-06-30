using WasteRecords.WebUI.Models.KinfOfWaste;
using WasteRecords.WebUI.Models.ReceivingCompany;
using WasteRecords.WebUI.Models.RecordModels;
using WasteRecords.WebUI.Models.Store;
using WasteRecords.WebUI.Models.Unit;
using WasteRecords.WebUI.Models.WasteType;

namespace WasteRecords.WebUI.Models
{
    public class IndexViewModel
    {
        public RecordListViewModel Record { get; set; }
        public List<StoreListViewModel> Stores { get; set; }
        public List<UnitListViewModel> Units { get; set; }
        public List<WasteTypeListViewModel> wasteTypes { get; set; }
        public List<KindOfWasteListViewModel> KindOfWastes { get; set; }
        public List<ReceivingCompanyListViewModel> ReceivingCompanies { get; set; }
    }
}
