using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.Unit;

namespace WasteRecords.WebUI.ApiServices.Interfaces
{
    public interface IUnitApiService
    {
        ResponseState<List<UnitListViewModel>> GetAll();
    }
}
