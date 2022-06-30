using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.KinfOfWaste;

namespace WasteRecords.WebUI.ApiServices.Interfaces
{
    public interface IKindOfWasteApiService
    {
        ResponseState<List<KindOfWasteListViewModel>> GetAll();
    }
}
