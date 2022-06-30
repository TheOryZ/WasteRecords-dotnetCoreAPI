using WasteRecords.WebUI.ApiServices.Interfaces;
using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.RecordModels;

namespace WasteRecords.WebUI.ApiServices.Services
{
    public class RecordApiService : IRecordApiService
    {
        public ResponseState<RecordListViewModel> Add(RecordAddViewModel model, string token)
        {
            throw new NotImplementedException();
        }

        public ResponseState<List<RecordListViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public ResponseState<List<RecordListWithRelationsViewModel>> GetAllWithParameters()
        {
            throw new NotImplementedException();
        }

        public ResponseState<RecordListViewModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseState<RecordUpdateViewModel> Remove(int id, string token)
        {
            throw new NotImplementedException();
        }

        public ResponseState<RecordUpdateViewModel> Update(RecordUpdateViewModel model, string token)
        {
            throw new NotImplementedException();
        }
    }
}
