using WasteRecords.WebUI.ApiServices.Interfaces;
using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.RecordModels;
using WasteRecords.WebUI.RestAccess.Interfaces;

namespace WasteRecords.WebUI.ApiServices.Services
{
    public class RecordApiService : IRecordApiService
    {
        private readonly IAccessRest _accessRest;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string url;
        public RecordApiService(IAccessRest accessRest, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _accessRest = accessRest;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            url = _configuration.GetValue<string>("ApiInfo:uri");
        }

        public ResponseState<List<RecordListViewModel>> GetAll()
        {
            var uri = string.Format("{0}/{1}", url, "Records");
            return _accessRest.GetMethod<List<RecordListViewModel>>(uri);
        }

        public ResponseState<List<RecordListWithRelationsViewModel>> GetAllWithParameters()
        {
            var uri = string.Format("{0}/{1}", url, "Records", "GetAllWithParameters");
            return _accessRest.GetMethod<List<RecordListWithRelationsViewModel>>(uri);
        }

        public ResponseState<RecordListViewModel> GetById(int id)
        {
            var uri = string.Format("{0}/{1}/{2}", url, "Records", id.ToString());
            return _accessRest.GetMethod<RecordListViewModel>(uri);
        }

        public ResponseState<RecordListViewModel> Add(RecordAddViewModel model, string token)
        {
            var uri = string.Format("{0}/{1}", url, "Records");
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Authorization", "Bearer " + token);
            return _accessRest.PostMethod<RecordListViewModel>(model, uri, headers);
        }

        public ResponseState<RecordUpdateViewModel> Update(RecordUpdateViewModel model, string token)
        {
            var uri = string.Format("{0}/{1}", url, "Records");
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Authorization", "Bearer " + token);
            return _accessRest.PutMethod<RecordUpdateViewModel>(model, uri, headers);
        }

        public ResponseState<RecordUpdateViewModel> Remove(int id, string token)
        {
            var uri = string.Format("{0}/{1}/{2}", url, "Records", id.ToString());
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Authorization", "Bearer " + token);
            return _accessRest.DeleteMethod<RecordUpdateViewModel>(uri, headers);
        }
    }
}
