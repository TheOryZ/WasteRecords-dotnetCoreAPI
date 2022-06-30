using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.RecordModels;

namespace WasteRecords.WebUI.ApiServices.Interfaces
{
    public interface IRecordApiService
    {
        ResponseState<List<RecordListViewModel>> GetAll();
        ResponseState<List<RecordListWithRelationsViewModel>> GetAllWithParameters();
        ResponseState<RecordListViewModel> GetById(int id);
        ResponseState<RecordListViewModel> Add(RecordAddViewModel model, string token);
        ResponseState<RecordUpdateViewModel> Update(RecordUpdateViewModel model, string token);
        ResponseState<RecordUpdateViewModel> Remove(int id, string token);
    }
}
