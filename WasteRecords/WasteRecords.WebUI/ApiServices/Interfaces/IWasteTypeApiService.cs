using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.WasteType;

namespace WasteRecords.WebUI.ApiServices.Interfaces
{
    public interface IWasteTypeApiService
    {
        ResponseState<List<WasteTypeListViewModel>> GetAll();
    }
}
