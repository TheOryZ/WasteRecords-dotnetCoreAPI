using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.Store;

namespace WasteRecords.WebUI.ApiServices.Interfaces
{
    public interface IStoreApiService
    {
        ResponseState<List<StoreListViewModel>> GetAll();
    }
}
