using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.ReceivingCompany;

namespace WasteRecords.WebUI.ApiServices.Interfaces
{
    public interface IReceivingCompanyApiService
    {
        ResponseState<List<ReceivingCompanyListViewModel>> GetAll();
    }
}
