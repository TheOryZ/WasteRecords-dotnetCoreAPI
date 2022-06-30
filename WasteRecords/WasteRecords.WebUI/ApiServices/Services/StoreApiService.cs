using WasteRecords.WebUI.ApiServices.Interfaces;
using WasteRecords.WebUI.Models;
using WasteRecords.WebUI.Models.Store;
using WasteRecords.WebUI.RestAccess.Interfaces;

namespace WasteRecords.WebUI.ApiServices.Services
{
    public class StoreApiService : IStoreApiService
    {
        private readonly IAccessRest _accessRest;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string url;
        public StoreApiService(IAccessRest accessRest, IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _accessRest = accessRest;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            url = _configuration.GetValue<string>("ApiInfo:uri");
        }
        public ResponseState<List<StoreListViewModel>> GetAll()
        {
            var uri = string.Format("{0}/{1}", url, "Stores");
            return _accessRest.GetMethod<List<StoreListViewModel>>(uri);
        }
    }
}
